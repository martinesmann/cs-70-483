using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module14.Slide13
{
   class Program
   {
      static void Main( string[] args )
      {
         using( FileStream fs = File.Open( @"C:\Demo.log",
                                           FileMode.OpenOrCreate,
                                           FileAccess.ReadWrite ) )
         {
            fs.WriteByte( 65 );

            // ...
         }
      }
   }
}
