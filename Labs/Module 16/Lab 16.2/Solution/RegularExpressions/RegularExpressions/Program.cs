using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressions
{
   class Program
   {
      static void Main( string[] args )
      {
         string singleGroupPattern = "(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)";
         string pattern = string.Format( @"\b{0}\.{0}\.{0}\.{0}\b", singleGroupPattern );
         Regex r = new Regex( pattern );

         Console.WriteLine( r.IsMatch( "127.0.0.1" ) );
         Console.WriteLine( r.IsMatch( "127.0.1" ) );
         Console.WriteLine( r.IsMatch( "127.0.0.a" ) );
         Console.WriteLine( r.IsMatch( "255.255.255.255" ) );
         Console.WriteLine( r.IsMatch( "999.999.999.999" ) );
      }
   }
}
