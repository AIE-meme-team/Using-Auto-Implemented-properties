using System;
using System.Collections.Generic;
using System.Text;

namespace Auto_implemented_properties
{
    class Rect
    {
        public double Length { get; set; }
        public double Width { get; set; }

        // Dont need to code a constructor or accessor methods

        public double getArea()
        {
            return Length * Width;
        }

    }
}
