using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module16.Slide19
{
   class Program
   {
      static void Main(string[] args)
      {
         byte[] encodedText = Encoding.Unicode.GetBytes("Hello, there!");
         
         Console.WriteLine(Encoding.Unicode.GetString(encodedText));
      }
   }
}
