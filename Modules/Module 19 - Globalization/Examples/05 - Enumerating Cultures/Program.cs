using System;
using System.Text;
using System.Globalization;
using System.Threading;

namespace Wincubate.Module19.Slide05
{
   class Program
   {
      static void Main(string[] args)
      {
         CultureInfo culture = new CultureInfo( "da-DK", false );

         Thread.CurrentThread.CurrentCulture = culture;
         Thread.CurrentThread.CurrentUICulture = culture;

         Console.WriteLine( DateTime.Now );

         #region Enumerating Cultures
         //foreach (CultureInfo ci in CultureInfo.GetCultures(CultureTypes.AllCultures))
         //{
         //   Console.WriteLine(string.Format("{0}\t{1}", ci.ToString(), ci.DisplayName));
         //}
         #endregion
      }
   }
}
