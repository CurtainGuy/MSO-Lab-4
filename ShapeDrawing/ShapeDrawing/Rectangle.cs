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
    public int X
    {
        get { return x; }
    }
    public int Y
    {
        get { return y; }
    }
    public int Width
    {
        get { return width; }
    }
    public int Height
    {
        get { return height; }
    }

}

