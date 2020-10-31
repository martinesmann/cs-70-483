using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Question
{
   class Program
   {
      static void Main(string[] args)
      {
         // a)
         //string date = DateTime.Today.Month.ToString("da-DK");

         // b)
         //string date = DateTimeFormatInfo.CurrentInfo.GetMonthName(DateTime.Today.Month);

         // c)
         DateTimeFormatInfo dtfi = new CultureInfo("da-DK", false).DateTimeFormat;
         DateTime dt = new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
         string date = dt.ToString(dtfi.LongDatePattern);

         // d)
         //Calendar cal = new CultureInfo("da-DK", false).Calendar;
         //DateTime dt = new DateTime( DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day);
         //string date = dt.ToString();
         
         Console.WriteLine(date);
      }
   }
}
