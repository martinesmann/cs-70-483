using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Wincubate.Module16.Slide14
{
   class Program
   {
      static void Main( string[] args )
      {
         string input = "03/24/2007";

         string s = Regex.Replace( input,
            @"\b(?<month>\d{1,2})/(?<day>\d{1,2})/(?<year>\d{2,4})\b",
            "${day}-${month}-${year}"
         );

         Console.WriteLine( s );
      }
   }
}
