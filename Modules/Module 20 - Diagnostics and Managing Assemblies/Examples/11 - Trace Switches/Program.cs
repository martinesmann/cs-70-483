using System;
using System.Diagnostics;

namespace Wincubate.Chapter10.Slide11
{
   class Program
   {
      static void Main(string[] args)
      {
         BooleanSwitch booleanSwitch = new BooleanSwitch("myClubSwitch", "Indicate to the user our preferred club");
         if (booleanSwitch.Enabled)
         {
            Console.WriteLine("No, we don't like Brøndby!");
         }

         TraceSwitch traceSwitch = new TraceSwitch("myTraceLevelSwitch", "Determines the level of tracing in application");
         if (traceSwitch.TraceError)
         {
            Trace.WriteLine("An error occurred!");
         }
         if (traceSwitch.TraceWarning)
         {
            Trace.WriteLine("Warning! Alert!");
         }
         if (traceSwitch.TraceInfo)
         {
            Trace.WriteLine("Someone ran the application");
         }
         if (traceSwitch.TraceVerbose)
         {
            Trace.WriteLine(string.Format("The time is now {0}", DateTime.Now.ToLongTimeString()));
         }


         Console.ReadLine();
      }
   }
}
