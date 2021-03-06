﻿using System;

namespace Wincubate.Module05.Slide11
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine( "Enter a number: " );
                int i = int.Parse( Console.ReadLine() );
                Console.WriteLine( "You entered the number {0}", i );
            }
            catch( OverflowException exception )
            {
                Console.WriteLine( exception );
            }
            catch( FormatException exception )
            {
                Console.WriteLine( exception );
            }
            catch
            {
                Console.WriteLine( "Something went haywire..!" );
            }

            Console.ReadLine();
        }
    }
}
