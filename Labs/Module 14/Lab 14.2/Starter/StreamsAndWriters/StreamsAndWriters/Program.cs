using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamsAndWriters
{
   class Program
   {
      static void Main( string[] args )
      {
         List<string> lines = new List<string>();
         bool done = false;
         while ( !done )
         {
            Console.WriteLine( "Input a string: " );
            string line = Console.ReadLine();

            if ( string.IsNullOrWhiteSpace( line ) )
            {
               done = true;
            }
            else
            {
               lines.Add( line );
            }
         }

         using( StreamWriter sw = new StreamWriter( @"Lines.txt") )
         {
            foreach (string line in lines )
            {
               sw.WriteLine( line );
            }
         }
      }
   }
}
