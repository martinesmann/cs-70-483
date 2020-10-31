using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module07.Slide12
{
    class A
    {
        public A( int x )
        {
            this.x = x;
            counter++;

            Console.WriteLine( "There are now {0} Car objects", counter );
        }
        ~A()
        {
            counter--;

            Console.WriteLine( "There are now {0} Car objects", counter );
        }

        public int x;

        public static int counter = 0;
    }

}
