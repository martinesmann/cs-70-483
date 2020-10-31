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
         CultureInfo ci = new CultureInfo("en-US");

         string dateString = "3/24/2007 9:34";
         DateTime dateValue;

         // Use custom formats with M and MM.
         if (DateTime.TryParseExact(
            dateString,
            "M/dd/yyyy h:mm",
            ci,
            DateTimeStyles.None,
            out dateValue)
            )
         {
            Console.WriteLine("Converted \"{0}\" to {1}",
               dateString,
               dateValue
            );
         }
         else
         {
            Console.WriteLine("\"{0}\" is not in an acceptable format",
               dateString);
         }
      }
   }
}
