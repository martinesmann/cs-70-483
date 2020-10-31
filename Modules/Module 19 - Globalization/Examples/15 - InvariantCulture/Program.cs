using System;
using System.Text;
using System.Globalization;
using System.Threading;

namespace Wincubate.Module19.Slide15
{
   class Program
   {
      static void Main(string[] args)
      {
         //CultureInfo culture = CultureInfo.InvariantCulture;
         //Thread.CurrentThread.CurrentCulture = culture;
         //Thread.CurrentThread.CurrentUICulture = culture;

         string[] places = { "Aalborg", "Århus", "Aabybro", "Nørre Aaby" };
         Array.Sort( places, StringComparer.InvariantCultureIgnoreCase );
         foreach (string name in places)
         {
            Console.WriteLine(name);
         }
      }
   }
}
