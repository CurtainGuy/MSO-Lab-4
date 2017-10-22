using System;
using System.Drawing;


public abstract class Shape
{

    protected Output output;
	public Shape()
	{
	}

    public abstract void Draw(Graphics Canvas);
	
}