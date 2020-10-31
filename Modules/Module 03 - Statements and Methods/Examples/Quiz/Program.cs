using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module03.Question
{
   class Program
   {
      static bool GetNumber( ref int number )
      {
         string s = Console.ReadLine();
         int n;
         if( int.TryParse( s, out n ) )
         {
            number = n;
            return true;
         }
         return false;
      }

      static void Main( string[] args )
      {
         bool ok = false;
         int i = 0;
         do
         {
            Console.WriteLine( "Input integer:");
            ok = GetNumber( ref i );
         } while ( !ok );
         Console.WriteLine( "You entered: " + i );
      }
   }
}
