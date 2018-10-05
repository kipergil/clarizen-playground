using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBHPro.Playground.Poco.Clarizen;
using Ekin.Clarizen;
using Ekin.Clarizen.Authentication;
using Ekin.Clarizen.Data;
using Ekin.Clarizen.Data.Queries.Conditions;
using ObjectDumper;

namespace BBHPro.Playground
{
    class Program
    {
        public static API ClarizenAPI { get; set; }
        public static string ClarizenUsername = ConfigurationManager.AppSettings["ClarizenUsername"];
        public static string ClarizenPassword = ConfigurationManager.AppSettings["ClarizenPassword"];
        public static bool UseSandbox = ConfigurationManager.AppSettings["UseSandbox"].ToLower() == "true";

        static void Main(string[] args)
        {
            Login();
            
            //use a helper function
            var userList = GetUsers();
            var user = userList.FirstOrDefault(i => i.FirstName == "Mustafa");
            Console.Write(user.DumpToString("User"));

            //define a custom action from user entity type
            var customActionName = "myCustomAction";
            var result1 = ExecuteCustomAction(user, customActionName);
            Console.Write(result1.DumpToString("Result"));

            //use clarizen API to query manually
            var result2 = EntityQueryForUser("User", new string[] { "FirstName", "LastName", "Email", "UserName" });
            Console.Write(result2.DumpToString("Result2"));

            //use generic repo class example for CRUD ops                  
            var userCondition = $@" Username = ""Mustafa"" ";

            var repoUser = new ClarizenRepository<User>(ClarizenAPI);
            var users = repoUser.LoadAll(" Active = '1' ");
            Console.Write(users.Take(1).FirstOrDefault().DumpToString("user"));

            var repoCustomer = new ClarizenRepository<Customer>(ClarizenAPI);
            var customers = repoCustomer.LoadAll("");
            Console.Write(customers.Take(1).FirstOrDefault().DumpToString("user"));

            var from = DateTime.Now.AddDays(-15).Date;
            var to = DateTime.Now.Date;

            //CZQL and grouping example on Timesheets
            var userTimesheets = GetUserMissingTimesheets(user, from, to);
            var timesheet = userTimesheets.FirstOrDefault();
            Console.Write(timesheet.DumpToString("Timesheet"));


            //update entity
            user.FirstName = "Changed name";
            var updateResult = ClarizenAPI.UpdateObject(user.id, user);
            Console.Write(updateResult.DumpToString("updateResult"));


            var deleteResult = ClarizenAPI.DeleteObject(user.id);
            Console.Write(deleteResult.DumpToString("deleteResult"));


            //If you are creating a new entity, in the id field you need to set the type with out value.
            var newUser = new User();
            user.id = "/User";
            user.FirstName = "My name";
            user.LastName = "My Lastname";
            var createResult = ClarizenAPI.CreateObject(user.id, user);
            Console.Write(createResult.DumpToString("createResult"));

        }

        public static void Login()
        {
            ClarizenAPI = new API();
            ClarizenAPI.isSandbox = UseSandbox;
            if (!ClarizenAPI.Login(ClarizenUsername, ClarizenPassword))
                return;

            Console.WriteLine("Login successful");
            Console.WriteLine("Server location: {0}", ClarizenAPI.serverLocation);
            Console.WriteLine("Session Id: {0}", ClarizenAPI.sessionId);
        }


        public static void GetSessionInfo()
        {
            getSessionInfo sessionInfo = ClarizenAPI.GetSessionInfo();
            if (sessionInfo.IsCalledSuccessfully)
                Console.WriteLine(sessionInfo.Data.DumpToString("getSessionInfo"));
            else
                Console.WriteLine(sessionInfo.Error);
        }

        public static List<User> GetUsers(string condition = "")
        {
            GetAllResult userListResult = ClarizenAPI.GetAll("User", typeof(User), new cZQLCondition(condition));

            List<User> users = (List<User>)userListResult.Data;

            users = users?.OrderBy(i => i.DisplayName).ToList();

            return users;
        }

        public static Ekin.Clarizen.Data.executeCustomAction ExecuteCustomAction(EntityId entity, string customActionName, fieldValue[] fieldValues = null)
        {
            var result = ClarizenAPI.ExecuteCustomAction(new Ekin.Clarizen.Data.Request.executeCustomAction(entity.id, customActionName, fieldValues));
            return result;
        }


        static dynamic[] EntityQueryForUser(string entityName, string[] fields)
        {
            entityQuery entityQuery = ClarizenAPI.GetAllEntities(entityName, fields);

            if (entityQuery.IsCalledSuccessfully)
            {
                Console.WriteLine("{0} entity found", entityQuery.Data.entities.Length);
                return entityQuery.Data.entities;
            }
            else
            {
                return null;
            }
        }


        public static List<TimesheetGroupResult> GetUserMissingTimesheets(User user, DateTime fromDate, DateTime toDate)
        {
            List<TimesheetGroupResult> items = new List<TimesheetGroupResult>();
            var groupBy = new string[] { "ReportedDate" };
            var orderBy = new orderBy[] { new orderBy("ReportedDate", "Ascending"), };
            var aggregations = new fieldAggregation[]
            {
                new fieldAggregation("Sum", "C_DurationHours", "TotalTime")
            };

            var condition = new cZQLCondition($@" ReportedBy = ""{user.id}"" AND ReportedDate >= ""{fromDate:yyyy-MM-dd}"" AND ReportedDate <= ""{toDate:yyyy-MM-dd}"" ");
            var paging = new paging()
            {
                from = 0,
                limit = Int32.MaxValue,
                hasMore = true
            };

            var query = new Ekin.Clarizen.Data.Queries.aggregateQuery("Timesheet", groupBy, orderBy, condition, aggregations, paging);
            var result = ClarizenAPI.AggregateQuery(query);

            if (result.IsCalledSuccessfully)
            {
                items = result.Data.entities.Select(i => Newtonsoft.Json.JsonConvert.DeserializeObject<TimesheetGroupResult>(i.ToString())).ToList();
            }

            return items;
        }

    }
}
