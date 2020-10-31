using System;

namespace Wincubate.Module05.Slide18
{
    class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine( "try" );

                //throw new Exception();
            }
            catch( Exception )
            {
                Console.WriteLine( "catch" );

                //return;
            }
            finally
            {
                Console.WriteLine( "finally" );

                // return
            }

            Console.ReadLine();
        }
    }
}
