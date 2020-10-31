using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module16.Slide20
{
   class Program
   {
      static void Main( string[] args )
      {
         string filename = @"C:\Tmp\utf7.txt";
         
         using( StreamWriter sw = new StreamWriter( filename, false, Encoding.UTF7 ) )
         {
            sw.WriteLine( "Hello, World!" );
         }

         using( StreamReader sr = new StreamReader( filename, Encoding.UTF7 ) )
         {
            Console.WriteLine( sr.ReadToEnd() );
         }
      }
   }
}
