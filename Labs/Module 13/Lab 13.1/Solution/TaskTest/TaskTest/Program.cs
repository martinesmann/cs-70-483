using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TaskTest
{
   class Program
   {
      static void Main( string[] args )
      {
         ComputeLengthSum().Wait();
      }

      static async Task ComputeLengthSum()
      {
         var t1 = CreateFetchTask( "http://www.jp.dk/" );
         var t2 = CreateFetchTask( "http://www.bt.dk/" );
         var t3 = CreateFetchTask( "http://www.eb.dk/" );

         await Task.WhenAll( t1, t2, t3 );
         
         int sum = t1.Result.Length + t2.Result.Length + t3.Result.Length;
         Console.WriteLine( "The sum of the document lengths are " + sum );
      }

      static Task<string> CreateFetchTask( string url )
      {
         WebClient client = new WebClient();
         return client.DownloadStringTaskAsync( "http://www.bt.dk/" );
      }
   }
}
