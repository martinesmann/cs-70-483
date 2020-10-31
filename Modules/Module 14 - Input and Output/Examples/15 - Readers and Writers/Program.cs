using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide15
{
   class Program
   {
      static void Main( string[] args )
      {
         string input;

         using( FileStream fs = File.Open( @"C:\Tmp\Demo.log",
                                           FileMode.OpenOrCreate,
                                           FileAccess.ReadWrite ) )
         {
            using( StreamReader sr = new StreamReader( fs ) )
            {
               input = sr.ReadToEnd();
            }
         }

         // Write the contents back
         using( FileStream fs = File.Open( @"C:\Tmp\DemoSW.log",
                                           FileMode.OpenOrCreate,
                                           FileAccess.ReadWrite ) )
         {
            using( StreamWriter sw = new StreamWriter( fs ) )
            {
               sw.WriteLine( input );
            }
         }
      }
   }
}
