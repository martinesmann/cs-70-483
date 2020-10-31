using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module20.Slide07
{
   class Program
   {
      static void Main( string[] args )
      {
#if DEBUG
         Console.WriteLine( "Running in DEBUG mode...");
#else
         Console.WriteLine( "Running in RELEASE mode...");
#endif

         DoStuff();
      }

      [Conditional( "EXAM" )]
      static void DoStuff()
      {
         Console.WriteLine( "Doing stuff..." );
      }
   }
}
