using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module10.Slide34
{
   class Program
   {
      static void Main( string[] args )
      {
         int[] numbers = { 42, 87, 112, 176, 255 };

         var result = numbers.Aggregate( ( product, i ) => product * i );
         Console.WriteLine( "The product of numbers is " + result );
      }
   }
}
