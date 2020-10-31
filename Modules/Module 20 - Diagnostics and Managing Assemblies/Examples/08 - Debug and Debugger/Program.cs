using System;
using System.Diagnostics;

namespace Wincubate.Module20.Slide08
{
   class Program
   {
      static int m_Number;

      static void Main(string[] args)
      {
         //Console.WriteLine(Debugger.IsAttached);

         Console.WriteLine("Input a number: ");
         string s = Console.ReadLine();
         if (int.TryParse(s, out m_Number))
         {
            if (m_Number == 87)
            {
               Method1();
            }
            //else if( m_Number == 112 )
            //{
            //   Debugger.Break();
            //}
         }
         Console.ReadLine();
      }

      //[Conditional( "EXAM" )]
      //[DebuggerStepThrough]
      //[DebuggerHidden]
      static void Method1()
      {
         Debug.Assert(m_Number == 87, "Number must be 87" );

         Method2("Look, Mom. I'm in Method1");
      }

      static void Method2(string s)
      {
         Debug.WriteLine("Method2() called!");

         Console.WriteLine(s);
      }
   }
}
