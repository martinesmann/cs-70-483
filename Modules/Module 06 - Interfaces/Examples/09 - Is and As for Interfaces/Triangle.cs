using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wincubate.Module06.Slide09
{
    public class Triangle : Shape, IPointy
    {
        public Triangle()
        {
        }
        public Triangle( string name )
            : base( name )
        {
        }
        public override void Draw()
        {
            Console.WriteLine( "Drawing {0} the Triangle", PetName );
        }

        // IPointy Implementation.
        public int Points
        {
            get
            {
                return 3;
            }
        }
    }
}
