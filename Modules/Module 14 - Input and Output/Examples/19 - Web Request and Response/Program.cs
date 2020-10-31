using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module14.Slide19
{
   class Program
   {
      static void Main( string[] args )
      {
         try
         {
            string uri = "http://www.jp.dk";
            HttpWebRequest request = WebRequest.Create( uri ) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            HttpStatusCode status = response.StatusCode;
            Console.WriteLine( "{0} succesfully received with status {1}",
               uri,
               status
            );

            Console.WriteLine();
            Console.WriteLine( response.ContentType );
            Console.ReadLine();

            // Reading response stream
            using ( Stream stream = response.GetResponseStream() )
            {
               using ( StreamReader reader = new StreamReader( stream ) )
               {
                  Console.WriteLine( reader.ReadToEnd() );
               }
            }
         }
         catch ( WebException exception )
         {
            Console.WriteLine( exception.Message );
         }
      }
   }
}
