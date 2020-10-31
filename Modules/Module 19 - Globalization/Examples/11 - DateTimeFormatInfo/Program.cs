using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Wincubate.Module19.Slide11
{
   class Program
   {
      static void Main(string[] args)
      {
         CultureInfo ci = new CultureInfo( "en-US" );
         DateTimeFormatInfo dtfi = ci.DateTimeFormat;
         
         DateTime now = DateTime.Now;

         // Formatting
         Console.WriteLine( now.ToString( "D", dtfi ) );

         // Parsing
         DateTime value;
         if( DateTime.TryParse("10-19-1986", dtfi, DateTimeStyles.None, out value ) )
         {
            Console.WriteLine("Successfully parsed DateTime from date string");
         }
         else
         {
            Console.WriteLine("Could not parse DateTime from date string");
         }
      }
   }
}
