using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide04
{
   class Program
   {
      static void Main( string[] args )
      {
         FileInfo fi = new FileInfo( @"C:\Tmp\Demo.log" );
         if( fi.Exists && fi.Length > 40)
         {
            fi.CopyTo( @"C:\Tmp\DemoBackup.log" );

            fi.Delete();
         }
      }
   }
}
