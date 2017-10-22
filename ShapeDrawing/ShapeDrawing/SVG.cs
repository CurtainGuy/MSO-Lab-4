using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

public class SVG : Output
{
    string total;
    public override void drawLines(Point[] points)
    {
        string s = "<polyline points=\"";
        int n = points.Length;
        for (int i = 0; i < n; i++)
        {
            string point = points[i].X + "," + points[i].Y;
            s = s + point + " ";
        }
        s += points[0].X + "," + points[0].Y + "\"";
        s = s + " style=\"fill:none;stroke:black;stroke-width1\" />";
        total += s;
        Console.WriteLine(total);
    }
    public override void drawCircle(Point middle, int radius)
    {
        string s = "<circle " + "cx=\"" + middle.X + "\" " + "cy=\"" + middle.Y + "\" " + "r=\"" + radius + "\" " + "stroke-width=\"1\" fill = \"none\" stroke=\"black\" />";
    }
}

 