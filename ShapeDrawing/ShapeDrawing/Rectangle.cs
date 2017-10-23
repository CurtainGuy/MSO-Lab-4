using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Rectangle : Shape
{

    private int x;
	private int y;
	private int width;
	private int height;

    public Rectangle(int x, int y, int width, int height)
    {
		this.x = x;
		this.y = y;
		this.width = width;
		this.height = height;
    }
    
	public override void Draw(Output output, Graphics Canvas = null)
    {
        Point[] pts = new Point[5];
        pts[0] = new Point(x, y);
        pts[1] = new Point(x + width, y);
        pts[2] = new Point(x + width, y + height);
        pts[3] = new Point(x, y + height);
        pts[4] = new Point(x, y);

        // Heeft dit nog Canvas nodig?
        output.drawLines(pts, Canvas);
        
    }
}

