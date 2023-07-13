using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Rectangle : Shape
{
    private double length;
    private double width;
    public double Length { get { return length; } set { length = value; } }
    public double Width { get { return width; } set { width = value; } }
    public Rectangle(double length, double width)
    {
        this.Length = length;
        this.Width = width;
    }
    public override void CalculateArea()
    {
        Console.WriteLine($"Area is: {length*width}");
    }
}
