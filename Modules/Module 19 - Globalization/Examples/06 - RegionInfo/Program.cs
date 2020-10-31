using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Wincubate.Module19.Slide06
{
   class Program
   {
      static void Main(string[] args)
      {
//         CultureInfo culture = new CultureInfo( "da-DK", true );

         string format = "   {0,-30}{1}";

         // Displays the property values of the RegionInfo for "US".
         RegionInfo ri = new RegionInfo("es-US");
         Console.WriteLine(format, "Name", ri.Name);
         Console.WriteLine(format, "DisplayName", ri.DisplayName);
         Console.WriteLine(format, "NativeName", ri.NativeName);
         Console.WriteLine(format, "IsMetric", ri.IsMetric);
         Console.WriteLine(format, "ThreeLetterISORegionName", ri.ThreeLetterISORegionName);
         Console.WriteLine(format, "ThreeLetterWindowsRegionName", ri.ThreeLetterWindowsRegionName);
         Console.WriteLine(format, "TwoLetterISORegionName", ri.TwoLetterISORegionName);
         Console.WriteLine(format, "CurrencySymbol", ri.CurrencySymbol);
         Console.WriteLine(format, "ISOCurrencySymbol", ri.ISOCurrencySymbol);
         Console.WriteLine();

         // Displays the property values of the RegionInfo for "US".
         ri = new RegionInfo("US");
         Console.WriteLine(format, "Name", ri.Name);
         Console.WriteLine(format, "DisplayName", ri.DisplayName);
         Console.WriteLine(format, "NativeName", ri.NativeName);
         Console.WriteLine(format, "IsMetric", ri.IsMetric);
         Console.WriteLine(format, "ThreeLetterISORegionName", ri.ThreeLetterISORegionName);
         Console.WriteLine(format, "ThreeLetterWindowsRegionName", ri.ThreeLetterWindowsRegionName);
         Console.WriteLine(format, "TwoLetterISORegionName", ri.TwoLetterISORegionName);
         Console.WriteLine(format, "CurrencySymbol", ri.CurrencySymbol);
         Console.WriteLine(format, "ISOCurrencySymbol", ri.ISOCurrencySymbol);
         Console.WriteLine();
      }
   }
}
