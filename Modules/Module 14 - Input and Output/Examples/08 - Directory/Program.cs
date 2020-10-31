using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide08
{
   class Program
   {
      static void Main( string[] args )
      {
         string name = @"C:\Tmp";
         if( Directory.Exists( name ) )
         {
            DirectoryInfo directory = Directory.GetParent( name );
            Console.WriteLine( directory.FullName );
         }
      }
   }
}
