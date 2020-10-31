using System;
using System.Diagnostics;

namespace Wincubate.Module20.Slide05
{
   class Program
   {
      static void Main(string[] args)
      {
         string eventSource = "Slide05 Application";
         if (!EventLog.SourceExists(eventSource))
         {
            EventLog.CreateEventSource(eventSource, "Application");
         }

         #region Write Entry
         //EventLog myLog = new EventLog("Application");
         //myLog.Source = eventSource;
         //myLog.WriteEntry("Don't trust this guy!", EventLogEntryType.Warning, 87, 1);
         #endregion

         #region Iterating Logs
         //foreach (EventLogEntry entry in myLog.Entries)
         //{
         //   Console.WriteLine(entry.Message);
         //}
         #endregion

         #region Deleting Event Sources
         // EventLog.DeleteEventSource(eventSource);
         #endregion
      }
   }
}
