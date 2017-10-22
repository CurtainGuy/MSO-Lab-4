using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapeDrawing
{
    class SVG : Output
    {
        public string drawRectangle(Rectangle shape)
        {
            string s = "<polyline points=";
            string line1 = shape.X + "," + shape.Y;
            string line2 = (shape.X + shape.Width) + "," + shape.Y;
            string line3 = (shape.X + shape.Width) + "," + (shape.Y + shape.Height);
            string line4 = shape.X + "," + (shape.Y + shape.Height);
            string line5 = line1;
            s = s + line1 + " " + line2 + " " + line3 + " " + line4 + " " + line5 + " style=fill:none;stroke:black;stroke-width1 />"
            return s;
        }
    }
}
