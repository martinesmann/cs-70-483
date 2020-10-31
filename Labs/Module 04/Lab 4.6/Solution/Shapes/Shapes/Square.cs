using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    class Square : Shape
    {
        public double Width
        {
            get;
            protected set;
        }

        public Square( double width )
        {
            Width = width;
        }

        public override string ToString()
        {
            return "Kvadrat med Sidelængde " + Width;
        }

        public override double Area
        {
            get
            {
                return Width * Width;
            }
        }
    }
}
