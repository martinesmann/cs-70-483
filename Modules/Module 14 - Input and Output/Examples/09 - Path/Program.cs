using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide09
{
   class Program
   {
      static void Main( string[] args )
      {
         string pathName = "Demo.log";

         if( Path.IsPathRooted( pathName ) == false )
         {
            string fullPathName = Path.Combine( @"C:\Tmp", pathName );

            Console.WriteLine( Path.GetDirectoryName( fullPathName ) );
            Console.WriteLine( Path.GetFileName( fullPathName ) );
            Console.WriteLine( Path.GetExtension( fullPathName ) );
         }

         //string randomName = Path.GetRandomFileName();      
      }
   }
}
