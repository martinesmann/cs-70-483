using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Wincubate.Module19.Slide16
{
   class Program
   {
      static void Main(string[] args)
      {
         // Create a CultureAndRegionInfoBuilder object for the new culture.
         CultureAndRegionInfoBuilder cib = new CultureAndRegionInfoBuilder("da-PP", CultureAndRegionModifiers.None);

         // Populate the new CultureAndRegionInfoBuilder object with culture information.
         cib.LoadDataFromCultureInfo(new CultureInfo("da-DK"));

         // Populate the new CultureAndRegionInfoBuilder object with region information.
         cib.LoadDataFromRegionInfo(new RegionInfo("DK"));

         // Define culture-specific settings.
         cib.CultureEnglishName = "Pepe Language";
         cib.CultureNativeName = "Pepe-sprog";
         cib.IsMetric = true;
         cib.ISOCurrencySymbol = "PPS";
         cib.RegionEnglishName = "Pepe Region";
         cib.RegionNativeName = "Pepepepe Repegipionpon";

         cib.NumberFormat.CurrencySymbol = "PP$";

         // Register the custom culture (requires administrative privileges).
         //cib.Register();

         // Display some of the properties of the custom culture.
         CultureInfo ci = new CultureInfo("da-PP");
         Console.WriteLine("Name: . . . . . . . . . . . . . {0}", ci.Name);
         Console.WriteLine("EnglishName:. . . . . . . . . . {0}", ci.EnglishName);
         Console.WriteLine("NativeName: . . . . . . . . . . {0}", ci.NativeName);
         Console.WriteLine("TwoLetterISOLanguageName: . . . {0}", ci.TwoLetterISOLanguageName);
         Console.WriteLine("ThreeLetterISOLanguageName: . . {0}", ci.ThreeLetterISOLanguageName);
         Console.WriteLine("ThreeLetterWindowsLanguageName: {0}", ci.ThreeLetterWindowsLanguageName);

         // cib.Save( @"C:\Tmp\da-PP.xml" );

         // CultureAndRegionInfoBuilder otherCib = CultureAndRegionInfoBuilder.CreateFromLdml( @"C:\Tmp\da-PP.xml" );

         //CultureAndRegionInfoBuilder.Unregister( "da-PP" );
      }
   }
}
