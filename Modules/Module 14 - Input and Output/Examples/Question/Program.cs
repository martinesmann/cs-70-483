using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Wincubate.Module14.Question
{
   class Program
   {
      static void Main( string[] args )
      {
         Task t = Upload( "http://www.wincubate.net/", 42, 87 );
      }

      public static Task<byte[]> Upload( string url, int i, int j )
      {
         var client = new WebClient();

         // a)
         //var data = string.Format( "a={0}&b={1}", i, j );
         //return client.UploadStringTaskAsync( new Uri( url ), data );

         // b)
         //var data = string.Format( "a={0}&b={1}", i, j );
         //return client.UploadFileTaskAsync( new Uri( url ), data );

         // c)
         //var data = string.Format( "a={0}&b={1}", i, j );
         //return client.UploadDataTaskAsync( new Uri( url ), Encoding.UTF8.GetBytes( data ) );

         // d)
         var nv = new NameValueCollection {{"a",i.ToString()}, {"b",j.ToString()} };
         return client.UploadValuesTaskAsync( new Uri( url ), nv );
      }
   }
}
