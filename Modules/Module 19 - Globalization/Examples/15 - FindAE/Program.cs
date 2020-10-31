using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;

namespace Wincubate.Module19.Slide15
{
   class Program
   {
      public static void Main()
      {
         string[] words = new string[] { "AEble", "Æble" };

         Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
         FindAE(words);

         Thread.CurrentThread.CurrentCulture = new CultureInfo("da-DK");
         FindAE(words);

         //Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
         //FindAE( words );
      }

      private static void FindAE(string[] words)
      {
         Console.WriteLine(Thread.CurrentThread.CurrentCulture + ":");
         Array.Sort(words);
         foreach (string s in words)
         {
            Console.WriteLine(" AE in {0}: {1}", s, s.IndexOf("AE"));
            Console.WriteLine(" Æ in {0}: {1}", s, s.IndexOf("Æ"));
         }
         Console.WriteLine();
      }
   }
}
