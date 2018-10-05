using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using BBHPro.Playground.Helpers;
using Ekin.Clarizen;
using Ekin.Clarizen.Data.Queries.Conditions;

namespace BBHPro.Playground
{
    public class ClarizenRepository<T> : IClarizenRepository<T> where T : EntityId, new()
    {
        public Ekin.Clarizen.API _api { get; set; }
        public ICacheManager _cacheManager { get; set; }
        public const int API_RETRY_COUNT = 3;
        public TimeSpan API_DELAY = TimeSpan.FromSeconds(3);


        public ClarizenRepository(Ekin.Clarizen.API api, ICacheManager cacheManager = null)
        {
            _api = api;
            _cacheManager = cacheManager;
        }

        public T GetById(string id)
        {
            var result = default(T);

            var apiResponse = _api.GetObject(id);

            if (apiResponse.IsCalledSuccessfully)
            {
                result = apiResponse.Data;
            }
            else
            {
                Console.WriteLine(apiResponse.Error);
            }

            return result;
        }

        public bool Insert(T entity)
        {
            var result = false;

            var apiResponse = _api.CreateObject(entity.id, entity);

            if (apiResponse.IsCalledSuccessfully)
            {
                result = true;
            }
            else
            {
                Console.WriteLine(apiResponse.Error);
            }

            return result;
        }

        public bool Update(T entity)
        {
            var result = false;

            var apiResponse = _api.UpdateObject(entity.id, entity);

            if (apiResponse.IsCalledSuccessfully)
            {
                result = true;
            }
            else
            {
                Console.WriteLine(apiResponse.Error);
            }

            return result;
        }

        public bool Upsert(T entity)
        {
            bool result;

            var found = GetById(entity.id);

            if (found == default(T))
            {
                result = Insert(entity);
            }
            else
            {
                result = Update(entity);
            }

            return result;
        }

        public bool Delete(T entity)
        {
            var result = false;

            var apiResponse = _api.DeleteObject(entity.id);

            if (apiResponse.IsCalledSuccessfully)
            {
                result = true;
            }
            else
            {
                Console.WriteLine(apiResponse.Error);
            }

            return result;
        }

        public bool DeleteById(string id)
        {
            var t = new T();
            return Delete(t);
        }

        public List<T> LoadAll(string customCondition = "", bool readFromFile = false, bool useCache = false, int cacheDuration = 60)
        {
            string entityName = typeof(T).Name;
            var items = new List<T>();
            var file = GetFilePath(entityName);
            if (readFromFile && string.IsNullOrEmpty(customCondition))
            {
                var fileInfo = new FileInfo(file);
                if (fileInfo.Exists)
                {
                    items = FileHelper.ReadFromJsonFile<List<T>>(file);
                    return items;
                }
            }

            var cacheKey = $"LoadAllByType:{entityName}:{GetEnvironmentSuffix()}:{customCondition}";

            if (useCache && _cacheManager != null)
            {
                items = _cacheManager.Get<List<T>>(cacheKey);

                if (items != null)
                {
                    return items;
                }
            }

            cZQLCondition condition = null;

            if (!string.IsNullOrEmpty(customCondition))
            {
                condition = new cZQLCondition(customCondition);
            }

            int currentRetry = 1;
            do
            {
                try
                {
                    GetAllResult result = _api.GetAll(entityName, typeof(T), condition);

                    if (result.Data == null || result.Errors.Count > 0)
                    {
                        items = null;

                        if (result != null && result.Errors.Any())
                        {
                            var msg = "Error occured on Clarizen API call. Retry count: " + currentRetry;
                            var detailedMsg = "Error: " + string.Join(System.Environment.NewLine, result.Errors.Select(i => i.message));
                            throw new Exception(msg, new Exception(detailedMsg));
                        }
                    }
                    else
                    {
                        items = (List<T>)result.Data;
                        break;
                    }
                }
                catch (Exception ex)
                {
                    var msg = ExceptionHelper.GetExceptionErrorMessage(ex, "Exception in Clarizen Data LoadAllByType");
                    Debug.WriteLine(msg);

                    currentRetry++;

                    // Check if the exception thrown was a transient/timeout exception
                    // based on the logic in the error detection strategy.
                    // Determine whether to retry the operation, as well as how
                    // long to wait, based on the retry strategy.
                    if (currentRetry > API_RETRY_COUNT || !ex.Message.Contains("timed out"))
                    {
                        // If this isn't a transient error or we shouldn't retry, 
                        // rethrow the exception.
                        items = new List<T>();
                    }

                }

                // Wait to retry the operation.
                // Consider calculating an exponential delay here and
                // using a strategy best suited for the operation and fault.
                Thread.Sleep(API_DELAY);

            } while (currentRetry <= API_RETRY_COUNT);

            if (useCache && _cacheManager != null)
            {
                _cacheManager.Set(cacheKey, items, cacheDuration);
            }

            if (readFromFile)
            {
                FileHelper.WriteToJsonFile(file, items);
            }

            return items;
        }

        public enum FolderType
        {
            Exports,
            Reports,
            Logs,
            Notification,
            Snapshots
        }

        public enum FileType
        {
            xlsx,
            json,
            txt
        }

        private string GetBasePath(FolderType folderType)
        {
            var basePath = "";

            if (HttpContext.Current != null && HttpContext.Current.Server != null)
            {
                basePath = HttpContext.Current.Server.MapPath("~\\" + folderType.ToString());
            }
            else
            {
                basePath = "C:\\bbhpro\\" + folderType.ToString();
            }

            return basePath;
        }
        private string GetFilePath(string entityType, FileType fileType = FileType.json)
        {
            string suffix = GetEnvironmentSuffix();
            var basePath = GetBasePath(FolderType.Exports);
            var path = "exported_" + "_" + suffix + "_" + entityType.ToString().ToLowerInvariant() + "." + fileType.ToString();
            var fullPath = Path.Combine(basePath, path);
            return fullPath;
        }

        private string GetEnvironmentSuffix()
        {
            return _api.isSandbox ? "sandbox" : "live";
        }
    }
}
