using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.IO.Compression;

namespace Wincubate.Module14.Slide17
{
   class Program
   {
      static void Main( string[] args )
      {
         // Compress
         using( FileStream inStream = File.OpenRead( @"C:\Tmp\Demo.log" ) )
         {
            using( FileStream outStream = File.Create( @"C:\Tmp\Demo.log.compressed" ) )
            {
               using( DeflateStream compress = new DeflateStream( outStream, CompressionMode.Compress ) )
               {
                  for( int i = 0 ; i < inStream.Length ; i++ )
                  {
                     compress.WriteByte( (byte) inStream.ReadByte() );
                  }
               }
            }
         }

         // Uncompress
         using( FileStream inStream = File.OpenRead( @"C:\Tmp\Demo.log.compressed" ) )
         {
            using( FileStream outStream = File.Create( @"C:\Tmp\Demo Uncompressed.log" ) )
            {
               using( DeflateStream uncompress = new DeflateStream( inStream, CompressionMode.Decompress ) )
               {
                  int i = 0;
                  while( ( i = uncompress.ReadByte() ) != -1 )
                  {
                     outStream.WriteByte( (byte) i );
                  }
               }
            }
         }
      }
   }
}
