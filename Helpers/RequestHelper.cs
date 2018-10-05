using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;

namespace BBHPro.Playground.Helpers
{
    public class RequestHelper
    {
        /// <summary>
        /// Gets query string value by name
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <returns>Query string value</returns>
        public static string QueryString(string name)
        {
            string result = string.Empty;
            if (HttpContext.Current != null && HttpContext.Current.Request.QueryString[name] != null)
                result = HttpContext.Current.Request.QueryString[name];
            return result;
        }

        /// <summary>
        /// Gets boolean value from query string
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <returns>Query string value</returns>
        public static bool QueryStringBool(string name)
        {
            string resultStr = QueryString(name).ToUpperInvariant();
            return (resultStr == "YES" || resultStr == "TRUE" || resultStr == "1");
        }

        /// <summary>
        /// Gets integer value from query string
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <returns>Query string value</returns>
        public static int QueryStringInt(string name)
        {
            string resultStr = QueryString(name).ToUpperInvariant();
            int result;
            Int32.TryParse(resultStr, out result);
            return result;
        }

        /// <summary>
        /// Gets integer value from query string
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <param name="defaultValue">Default value</param>
        /// <returns>Query string value</returns>
        public static int QueryStringInt(string name, int defaultValue)
        {
            string resultStr = QueryString(name).ToUpperInvariant();
            if (resultStr.Length > 0)
            {
                return Int32.Parse(resultStr);
            }
            return defaultValue;
        }

        /// <summary>
        /// Gets GUID value from query string
        /// </summary>
        /// <param name="name">Parameter name</param>
        /// <returns>Query string value</returns>
        public static Guid? QueryStringGuid(string name)
        {
            string resultStr = QueryString(name).ToUpperInvariant();
            Guid? result = null;
            try
            {
                result = new Guid(resultStr);
            }
            catch (Exception)
            {
            }
            return result;
        }

        /// <summary>
        /// Gets server variable by name
        /// </summary>
        /// <param name="name">Name</param>
        /// <returns>Server variable</returns>
        public static string ServerVariables(string name)
        {
            string tmpS = String.Empty;
            try
            {
                if (HttpContext.Current.Request.ServerVariables[name] != null)
                {
                    tmpS = HttpContext.Current.Request.ServerVariables[name];
                }
            }
            catch
            {
                tmpS = String.Empty;
            }
            return tmpS;
        }

        /// <summary>
        /// Gets this page name
        /// </summary>
        /// <returns></returns>
        public static string GetThisPageUrl(bool includeQueryString = false)
        {
            string url = string.Empty;
            if (HttpContext.Current == null)
                return url;

            if (includeQueryString)
            {
                string storeHost = GetApplicationAddress();
                if (storeHost.EndsWith("/"))
                    storeHost = storeHost.Substring(0, storeHost.Length - 1);
                url = storeHost + HttpContext.Current.Request.RawUrl;
            }
            else
            {
                url = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Path);
            }
            return url;
        }

        /// <summary>
        /// Gets store host location
        /// </summary>
        /// <returns>Store host location</returns>
        public static string GetApplicationAddress()
        {
            string result = ConfigurationManager.AppSettings["ApplicationUrl"];

            if (!result.EndsWith("/"))
                result += "/";

            var useSsl = false;

            if (!string.IsNullOrEmpty(ConfigurationManager.AppSettings["Use_HTTP_X_FORWARDED_PROTO"]) &&
                Convert.ToBoolean(ConfigurationManager.AppSettings["Use_HTTP_X_FORWARDED_PROTO"]))
            {
                useSsl = string.Equals(ServerVariables("HTTP_X_FORWARDED_PROTO"), "https",
                    StringComparison.OrdinalIgnoreCase);
            }
            else if (HttpContext.Current.Request.IsSecureConnection)
            {
                useSsl = true;
            }

            if (useSsl)
            {
                result = result.Replace("http:/", "https:/");
            }

            if (!result.EndsWith("/"))
                result += "/";

            return result;
        }

        /// <summary>
        /// Reloads current page
        /// </summary>
        public static void ReloadCurrentPage()
        {
            string storeHost = GetApplicationAddress();
            if (storeHost.EndsWith("/"))
                storeHost = storeHost.Substring(0, storeHost.Length - 1);
            string url = storeHost + HttpContext.Current.Request.RawUrl;
            HttpContext.Current.Response.Redirect(url);
        }

        public static string ResolveUrl(string originalUrl)
        {
            if (originalUrl == null)
                return null;

            // *** Absolute path - just return
            if (originalUrl.IndexOf("://") != -1)
                return originalUrl;

            // *** Fix up image path for ~ root app dir directory
            if (originalUrl.StartsWith("~"))
            {
                string newUrl = "";
                if (HttpContext.Current != null)
                    newUrl = HttpContext.Current.Request.ApplicationPath +
                             originalUrl.Substring(1).Replace("//", "/");
                else
                {
                    var basePath = AppDomain.CurrentDomain.BaseDirectory;
                    newUrl = basePath + originalUrl.Substring(1).Replace("//", "/");
                }

                // *** Just to be sure fix up any double slashes
                return newUrl;
            }
            else
            {
                var basePath = AppDomain.CurrentDomain.BaseDirectory;
                return basePath + originalUrl;
            }
        }

        public static string MakeHttpsUrl(string url)
        {
            url = url.Replace("~/", "");
            string appAddress = GetApplicationAddress();
            url = appAddress.Replace("http://", "https://") + url;
            return url;
        }

        public static string GetIpAddress()
        {
            if (HttpContext.Current == null)
            {
                return String.Empty;
            }

            string ip = HttpContext.Current.Request.ServerVariables["HTTP_CLIENT_IP"];
            string alternateIp = HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            return (String.IsNullOrEmpty(ip)) ? (String.IsNullOrEmpty(alternateIp) ? String.Empty : alternateIp) : ip;
        }

        public static string GetRequestParams(HttpRequest logRequest)
        {
            StringBuilder sb = new StringBuilder();

            try
            {
                if (logRequest == null) return string.Empty;

                sb.AppendLine("Url : " + logRequest.RawUrl);
                sb.AppendLine("Host :" + logRequest.Url?.Host?.ToLowerInvariant());
                sb.AppendLine("ContentType : " + logRequest.ContentType);
                sb.AppendLine("HttpMethod : " + logRequest.HttpMethod);
                sb.AppendLine("UrlReferrer : " + logRequest.UrlReferrer?.AbsolutePath);
                sb.AppendLine("UserAgent : " + logRequest.UserAgent);
                sb.AppendLine("Platform : " + logRequest.Browser?.Platform);
                sb.AppendLine("Browser Version : " + logRequest.Browser?.Version);
                sb.AppendLine("Browser : " + logRequest.Browser?.Browser);
                sb.AppendLine("MachineUserName : " + System.Environment.UserName);
                sb.AppendLine("MachineName : " + System.Environment.MachineName);

                if (logRequest.Form.AllKeys.Any())
                {
                    sb.AppendLine("Form Params : ");

                    for (int i = 0; i < logRequest.Form.Count; i++)
                    {
                        sb.AppendLine(logRequest.Form.AllKeys[i] + " : " + logRequest.Form[i]);
                    }
                }
                sb.AppendLine("");
                sb.AppendLine("Headers:");
                foreach (var key in logRequest.Headers.AllKeys)
                {
                    sb.AppendLine($"{key} : {logRequest.Headers[key]}");
                }
            }
            catch (Exception)
            {
            }

            return sb.ToString();
        }

        public static string GetRequestContent(HttpRequest logRequest)
        {
            string rawRequest = "";

            try
            {
                if (logRequest == null) return string.Empty;
                logRequest.InputStream.Position = 0;
                StreamReader stream = new StreamReader(logRequest.InputStream);
                string content = stream.ReadToEnd();
                rawRequest = HttpUtility.UrlDecode(content);

            }
            catch (Exception)
            {
            }

            return rawRequest;
        }

        public static HttpRequest GetRequest()
        {
            if (HttpContext.Current != null)
                return HttpContext.Current.Request;

            return null;
        }


        public static bool IsRunningOnAzure()
        {
            return !String.IsNullOrEmpty(Environment.GetEnvironmentVariable("WEBSITE_SITE_NAME"));
        }

        public static bool IsLiveSystem()
        {
            return !String.IsNullOrEmpty(Environment.GetEnvironmentVariable("IS_LIVE_SYSTEM"));
        }
    }
}