using System;
using System.Diagnostics;
using System.Text;

namespace BBHPro.Playground.Helpers
{
    public static class ExceptionHelper
    {
        public static string GetExceptionErrorMessage(Exception ex, string errorTitle = "", bool writeToEventLog = false, EventLogEntryType errorType = EventLogEntryType.Error)
        {
            StringBuilder errorLog = new StringBuilder();

            errorLog.AppendLine("\nMessage : " + AlwaysConvert.ToString(ex.Message));
            errorLog.AppendLine("\nStack Trace : " + AlwaysConvert.ToString(ex.StackTrace));
            errorLog.AppendLine("\nSource : " + AlwaysConvert.ToString(ex.Source));
            errorLog.AppendLine("\nTarget Site : " + AlwaysConvert.ToString(ex.TargetSite));

            if (ex.InnerException != null)
            {
                errorLog.AppendLine("\nInner Ex. Message : " + AlwaysConvert.ToString(ex.InnerException.Message));
                errorLog.AppendLine("\nInner Ex. Stack Trace : " + AlwaysConvert.ToString(ex.InnerException.StackTrace));
                errorLog.AppendLine("\nInner Ex. Source : " + AlwaysConvert.ToString(ex.InnerException.Source));
            }

            if (writeToEventLog)
            {
                WriteEventLog(ex, errorTitle, errorLog.ToString(), errorType);
            }

            return errorLog.ToString();
        }

        public static void WriteEventLog(Exception ex, string errorTitle = "", string message = "", EventLogEntryType errorType = EventLogEntryType.Error)
        {
            EventLog log = new EventLog(errorTitle);
            log.MachineName = Environment.MachineName;
            log.Source = ex.Source;
            log.WriteEntry(message.ToString(), errorType);
        }
    }
}
