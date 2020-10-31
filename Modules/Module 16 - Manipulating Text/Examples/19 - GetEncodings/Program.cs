using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module16.Slide19
{
   class Program
   {
      static void Main( string[] args )
      {
         EncodingInfo[] ei = Encoding.GetEncodings();
         foreach( EncodingInfo e in ei )
         {
            Console.WriteLine( "{0}: {1}, {2}", e.CodePage, e.Name, e.DisplayName );
         }
      }
   }
}
