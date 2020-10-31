using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module09.Slide23
{
    class Program
    {
        public delegate int SimpleNumberDelegate();

        static void Main( string[] args )
        {
            // No parameters
            SimpleNumberDelegate d = () => 87;
            Console.WriteLine( d.Invoke() );

            //// One parameter
            //Predicate<int> p = ( i => i == 87 );

            //int[] array = { 42, 87, 112, 59, 33, 128 };

        }
    }
}
