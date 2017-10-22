using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShapeDrawing
{
    abstract class Output
    {
        public virtual void drawLines(Point[] points)
        {
            
        }
        public virtual void drawCircle(Point middle, int radius)
        {

        }
    }
}
