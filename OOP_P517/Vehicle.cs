using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

 class Vehicle
{
    private string color;
    private int year;
    public string Color 
    {
        get
        {
            return color;
        }
        set 
        {
            color = value;
        }
    }
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }

    public Vehicle(string color, int year)
    {
        this.Color = color;
        this.Year = year;   
    }
    public virtual void ShowInfo()
    {
        Console.WriteLine($"Color:{Color} Year:{Year}");
    }
}
