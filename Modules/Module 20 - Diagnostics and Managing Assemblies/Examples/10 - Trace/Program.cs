using System;
using System.Diagnostics;

namespace Wincubate.Module20.Slide10
{
   class Program
   {
      static void Main(string[] args)
      {
         //Debug.Listeners.Add( new ConsoleTraceListener() );
         //Trace.Listeners.Add( new TextWriterTraceListener( @"C:\Tmp\Trace.txt" ) );

         Debug.AutoFlush = true;

         Debug.Indent();

         Debug.WriteLine("Debug: Starting application");
         Trace.WriteLine("Trace: Starting application");

         Console.WriteLine("Hello, world!");

         Debug.WriteLine("Debug: Ending application");
         Trace.WriteLine("Trace: Ending application");

         Console.ReadLine();
      }
   }
}
