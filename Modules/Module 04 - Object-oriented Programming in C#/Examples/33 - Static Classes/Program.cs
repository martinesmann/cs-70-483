using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide33
{
    static class TimeUtility
    {
        public static void PrintTime()
        {
            Console.WriteLine( DateTime.Now.ToShortTimeString() );
        }
        public static void PrintDate()
        {
            Console.WriteLine( DateTime.Today.ToShortDateString() );
        }
    }

    class Program
    {
        static void Main()
        {
            TimeUtility.PrintTime();
            TimeUtility.PrintDate();
        }
    }
}
