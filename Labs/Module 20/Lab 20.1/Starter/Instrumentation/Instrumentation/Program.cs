﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Instrumentation
{
   class Program
   {
      static void Main( string[] args )
      {
         // TODO 1
         Console.WriteLine( "Start: Starting with Debugger on" );

         while ( true )
         {
            string input = Console.ReadLine();

            int number;
            if ( int.TryParse( input, out number ) )
            {
               // TODO 2
               LogToConsole( "Successful input" );
            }
            else
            {
               // TODO 3
               break;
            }
         }

         End();
      }

      static void LogToConsole( string message, string detail = "" )
      {
         Console.WriteLine( "Log: {0} - {1}", message, detail );
      }

      // TODO 4
      static void End()
      {
         Console.WriteLine( "End: Program ended with preprocessor define \"LAB20\" on" );
      }
   }
}
