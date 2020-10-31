using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide15
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine( "Enter a number: " );
            int i = int.Parse( Console.ReadLine() );

            Console.WriteLine( "Enter another number: " );
            int j = int.Parse( Console.ReadLine() );

            if( i == j )
            {
                throw new ArgumentException( "Identical numbers entered!" );
            }

            Console.ReadLine();
        }
    }
}
