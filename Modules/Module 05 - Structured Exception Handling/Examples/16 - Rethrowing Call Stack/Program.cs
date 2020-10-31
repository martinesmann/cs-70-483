using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module05.Slide16
{
    class Program
    {
        static void Main()
        {
           try
           {
              A();
           }
           catch ( Exception e )
           {
              Console.WriteLine( e.StackTrace );
           }
        }

       static void A()
        {
           try
           {
              B();
              C();
           }
           catch ( OverflowException oe )
           {
              Console.WriteLine( "Cannot deal with overflow here! :-(" );
              throw;
           }

           Console.ReadLine();
        }

       static void B()
       {
          Console.WriteLine( "Enter a number: " );
          int i = int.Parse( Console.ReadLine() ); // <-- !!
          Console.WriteLine( "You entered the number {0}", i );
       }

       static void C()
       {
          Console.WriteLine( "Enter a number: " );
          int i = int.Parse( Console.ReadLine() ); // <-- !!
          Console.WriteLine( "You entered the number {0}", i );
       }

    }
}
