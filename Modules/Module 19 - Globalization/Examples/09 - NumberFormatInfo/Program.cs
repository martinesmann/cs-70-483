using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Wincubate.Module19.Slide09
{
   class Program
   {
      static void Main(string[] args)
      {
         //CultureInfo ci = new CultureInfo( "da-DK" );
         CultureInfo ci = new CultureInfo("en-US");
         NumberFormatInfo nfi = ci.NumberFormat;

         string number = 99999.ToString("N2", nfi);
         Console.WriteLine(number);

         double value;
         if (double.TryParse("99,999.00", NumberStyles.Any, nfi, out value))
         {
            Console.WriteLine("Successfully parsed double from number string");
         }
         else
         {
            Console.WriteLine("Could not parse double from number string");
         }
      }
   }
}
