using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Rectangle : Square
    {
        public double Height
        {
            get;
            protected set;
        }

        public Rectangle( double width, double height )
            : base( width )
        {
            Height = height;
        }

        public override string ToString()
        {
            return string.Format( "Rektangel med Sidelængder {0} og {1}",
               Width,
               Height );
        }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
}
