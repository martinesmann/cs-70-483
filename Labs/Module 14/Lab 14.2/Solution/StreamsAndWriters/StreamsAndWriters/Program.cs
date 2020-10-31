using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
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

         // Compress
         using ( FileStream fs = File.OpenWrite( @"Lines.txt.compressed" ) )
         {
            using ( DeflateStream ds = new DeflateStream( fs, CompressionMode.Compress ) )
            {
               using ( StreamWriter sw = new StreamWriter( ds ) )
               {
                  foreach ( string line in lines )
                  {
                     sw.WriteLine( line );
                  }
               }
            }
         }

         // Read back and decompress
         using ( FileStream fs = File.OpenRead( @"Lines.txt.compressed" ) )
         {
            using ( DeflateStream ds = new DeflateStream( fs, CompressionMode.Decompress ) )
            {
               using ( StreamReader sr = new StreamReader( ds ) )
               {
                  Console.WriteLine( sr.ReadToEnd() );
               }
            }
         }

      }
   }
}
