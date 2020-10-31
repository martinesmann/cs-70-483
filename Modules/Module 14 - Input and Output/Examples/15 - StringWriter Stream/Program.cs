using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Wincubate.Module04.Slide18StringWriterStream
{
   class Program
   {
      static void Main( string[] args )
      {
         StringBuilder sb = new StringBuilder();

         using( StringWriter sw = new StringWriter( sb ) )
         {
            sw.WriteLine( "This is a stream from a StringWriter" );
         }

         // Create stream from StringBuilder
         byte[] bytes = Encoding.UTF8.GetBytes( sb.ToString() );

         // Now read stream
         using( MemoryStream ms = new MemoryStream( bytes ) )
         {
            using( StreamReader sr = new StreamReader( ms ) )
            {
               Console.WriteLine( sr.ReadToEnd() );
            }
         }
      }
   }
}
