using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module04.Slide42
{
    class Program
    {
        static void Main( string[] args )
        {
            Rectangle r = new Rectangle
            {
                TopLeft = new Point { X = 10, Y = 10 },
                BottomRight = new Point { X = 90, Y = 90 }
            };
            Console.WriteLine( r );
        }
    }
}
