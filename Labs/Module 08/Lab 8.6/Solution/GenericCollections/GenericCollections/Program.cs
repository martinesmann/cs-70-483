using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
   class Program
   {
      static void Main( string[] args )
      {
         LineUp l = new LineUp();
         l.Add( 11, "Peter Graulund" );
         l.Add( 27, "Anders Kure" );
         l.Add( 6, "Martin Jørgensen" );
         l.Add( 11, "Søren Larsen" );
         l.Add( 23, "Brian Steen Nielsen" );
         l.Add( 6, "Kasper Povlsen" );

         foreach ( int number in l.GetSharedNumbers() )
         {
            Console.WriteLine( "Multiple players have played with number {0}", number );
         }
      }
   }
}
