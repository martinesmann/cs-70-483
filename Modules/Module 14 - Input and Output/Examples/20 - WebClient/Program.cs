using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module14.Slide20
{
   class Program
   {
      static void Main( string[] args )
      {
         Download();

         Console.ReadLine();
      }

      async static void Download()
      {
         string url1 = "http://upload.wikimedia.org/wikipedia/commons/7/7b/Anders_Hejlsberg_at_PDC2008.jpg";
         string url2 = "http://da.wikipedia.org/wiki/Anders_Hejlsberg";

         using ( WebClient client = new WebClient() )
         {
            await client.DownloadFileTaskAsync( url1, "1.jpg" );
            string result = await client.DownloadStringTaskAsync( url2 );

            Console.WriteLine( result );
         }         
      }
   }
}
