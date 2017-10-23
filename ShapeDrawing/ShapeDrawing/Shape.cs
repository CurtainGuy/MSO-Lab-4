using System;
using System.Drawing;


public abstract class Shape
{

    protected Output output;
	public Shape()
	{
	}

    public virtual void Draw(Output output, Graphics Canvas = null)
    {

    }
        
	
}