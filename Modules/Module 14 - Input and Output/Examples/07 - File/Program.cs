using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide07
{
   class Program
   {
      static void Main( string[] args )
      {
         string filename = @"C:\Tmp\Demo.log";
         if( File.Exists( filename ) )
         {
            File.Copy( filename, filename + ".old" );
            File.Delete( filename );
         }
      }
   }
}
