using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Wincubate.Module16.Slide10
{
   class Program
   {
      static void Main( string[] args )
      {
         Regex regex = new Regex( @"^-?\d+(\,\d{1,2})?$" );

         Console.WriteLine( regex.IsMatch( "-87,0" ) );
         Console.WriteLine( regex.IsMatch( "42,000" ) );
         Console.WriteLine( regex.IsMatch( "1111,22" ) );
         Console.WriteLine( regex.IsMatch( "9999,88$" ) );
         Console.WriteLine( regex.IsMatch( "9.999,88" ) );
      }
   }
}
