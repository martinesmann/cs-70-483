using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Wincubate.Module20.Slide06
{
   class Program
   {
      static void Main(string[] args)
      {
         string logName = "TTL Event Log";
         EventLog eventLog = new EventLog(logName);

         string eventSource = "Slide06 Application";
         if (!EventLog.SourceExists(eventSource))
         {
            EventLog.CreateEventSource(eventSource, logName);
         }

         eventLog.Source = eventSource;
         eventLog.WriteEntry("DO trust this guy!", EventLogEntryType.Information, 87, 1);

         //EventLog.DeleteEventSource(eventSource);

         //EventLog.Delete(logName);
      }
   }
}
