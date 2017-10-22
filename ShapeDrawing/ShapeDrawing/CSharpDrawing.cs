using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class CSharpDrawing : Output
{
    //HIER MOET EEN GRAPHICS AAN WORDEN MEEGEGEVEN
    Graphics Canvas;
    Pen pen = new Pen(Color.Black);
    public CSharpDrawing(Graphics graphics)
    {
        Canvas = graphics;
    }

    public override void drawLines(Point[] points)
    {
        int n = points.Length - 1;
        for (int i = 0; i < n; i++)
        {
            int y = points[i].Y;
            Canvas.DrawLine(pen, points[i].X, points[i].Y, points[i + 1].X, points[i + 1].Y);
        }
        Canvas.DrawLine(pen, points[n].X, points[n].Y, points[0].X, points[0].Y);

    }
    public override void drawCircle(Point middle, int radius)
    {
        Canvas.DrawEllipse(pen, middle.X, middle.Y, radius, radius);
    }
}
