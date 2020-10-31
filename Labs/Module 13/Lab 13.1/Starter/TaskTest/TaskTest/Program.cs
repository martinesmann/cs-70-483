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
         // TODO
         throw new NotImplementedException();
      }

      // TODO
      static Task ComputeLengthSum()
      {
         var t1 = CreateFetchTask( "http://www.jp.dk/" );
         var t2 = CreateFetchTask( "http://www.bt.dk/" );
         var t3 = CreateFetchTask( "http://www.eb.dk/" );

         // TODO
         throw new NotImplementedException();
      }

      static Task<string> CreateFetchTask( string url )
      {
         // TODO
         throw new NotImplementedException();
      }
   }
}
