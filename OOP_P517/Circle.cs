using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Circle : Shape
{
    private double radius;
    public double Radius { get { return radius; } set { radius = value; } }
    public Circle(double radius)
    {
        this.Radius = radius;   
    }
    public override void CalculateArea()
    {
        Console.WriteLine($"Area: {Math.PI * Math.Pow(radius,2) }");
    }

}
