using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

public class SVG : Output
{
    string total;

    public override void drawLines(Point[] points, Graphics Canvas = null)
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
        total += s + "\n";
    }

    public override void drawCircle(Point middle, int radius, Graphics Canvas = null)
    {
        radius /= 2;
        string s = "<circle " + "cx=\"" + (middle.X + radius) + "\" " + "cy=\"" + (middle.Y + radius) +"\" " + "r=\"" + (radius) + "\" " + "stroke-width=\"1\" fill = \"none\" stroke=\"black\" />";
        total += s + "\n";
    }

    public void export()
    {
        Stream stream;
        SaveFileDialog saveFileDialog = new SaveFileDialog();

        saveFileDialog.Filter = "SVG files|*.svg";
        saveFileDialog.RestoreDirectory = true;



        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            if ((stream = saveFileDialog.OpenFile()) != null)
            {
                // Insert code here that generates the string of LaTeX
                //   commands to draw the shapes
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    // Write strings to the file here using:
                    //   writer.WriteLine("Hello World!");
                    writer.WriteLine("<?xml version=\"1.0\" standalone=\"no\"?>");
                    writer.WriteLine("<!DOCTYPE svg PUBLIC \" -//W3C//DTD SVG 1.1//EN\"");
                    writer.WriteLine("\"http://www.w3.org/Graphics/SVG/1.1/DTD/svg11.dtd\">");
                    writer.WriteLine("<svg xmlns=\"http://www.w3.org/2000/svg\" version=\"1.1\">");
                    writer.WriteLine(total + "</svg>");
                }
            }
        }
    }
}

 