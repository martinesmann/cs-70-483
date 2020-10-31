using System;
using System.Text;
using System.Globalization;
using System.Threading;

namespace Wincubate.Module19.Slide13
{
   class Program
   {
      static void Main(string[] args)
      {
         #region CompareInfo
         CultureInfo culture = new CultureInfo("da-DK");
         CompareInfo compareInfo = culture.CompareInfo;
         Console.WriteLine( compareInfo.Compare("Aarhus", "Århus", CompareOptions.IgnoreCase));
         #endregion

         #region Sorting
         //Thread.CurrentThread.CurrentCulture = culture;
         //Thread.CurrentThread.CurrentUICulture = culture;

         //string[] places = { "Aalborg", "Århus", "Aabybro", "Nørre Aaby" };
         ////Array.Sort( places, StringComparer.Create( culture, true ) );
         //Array.Sort(places);
         //foreach (string name in places)
         //{
         //   Console.WriteLine(name);
         //}
         #endregion
      }
   }
}
