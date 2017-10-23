using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


public abstract class Output
{
    public virtual void drawLines(Point[] points, Graphics Canvas = null)
    {

    }
    public virtual void drawCircle(Point middle, int radius, Graphics Canvas = null)
    {

    }
}
