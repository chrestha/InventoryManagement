using InventoryManagement.ErrorLog.Interface;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace InventoryManagement.ErrorLog
{
    public class EventViewerLogger : IErrorLogger
    {
        public void LogMessage(Exception ex)
        {
            EventLog objEventLog = new EventLog();
            string sourceName = HttpContext.Current.Server.MapPath("~/SystemLogs/EventLog/");
            string logName = "EventLog.log";
            if (!(EventLog.SourceExists(sourceName)))
            {
                EventLog.CreateEventSource(sourceName, logName);
            }
            objEventLog.Source = sourceName;
            string message = String.Format("Message: {0} \n StackTrace: {1} \n Date/Time: {2}", ex.Message, ex.StackTrace, DateTime.Now.ToString());
            objEventLog.WriteEntry(message, EventLogEntryType.Error);
        }
    }
}