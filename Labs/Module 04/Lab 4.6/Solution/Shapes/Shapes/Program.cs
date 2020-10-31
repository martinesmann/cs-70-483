using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Program
    {
        static void Main( string[] args )
        {
            Shape[] shapes = { new Circle( 3 ), new Square( 4 ), new Square( 5 ), new Rectangle( 6, 7 ) };

            foreach( Shape shape in shapes )
            {
                Console.WriteLine( "Arealet af {0} er {1}",
                   shape,
                   shape.Area );
            }
        }
    }
}
