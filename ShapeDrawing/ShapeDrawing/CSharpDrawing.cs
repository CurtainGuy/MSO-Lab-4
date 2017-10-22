using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace ShapeDrawing
{
    class CSharpDrawing : Output
    {
        Pen pen = new Pen(Color.Black);
        
        public void drawRectangle(Rectangle shape, Graphics Canvas)
        {
            int x = shape.X;
            int y = shape.Y;
            int height = shape.Height;
            int width = shape.Width;
            Canvas.DrawLine(pen, x, y, x + width, y);
            Canvas.DrawLine(pen, x + width, y, x + width, y + height);
            Canvas.DrawLine(pen, x + width, y + height, x, y + height);
            Canvas.DrawLine(pen, x, y + height, x, y);
        }
        public void drawCircle(Circle shape)
        {

        }
    }
}
