using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Car : Vehicle
{
    private string brand;
    private string model;
    private double fuelCapacity;
    private double fuelFor1Km;
    private double currentFuel;
    public string Brand { get => brand; set { brand = value; } }
    public string Model { get => model; set { model = value; } }
    public double FuelCapacity { get => fuelCapacity; set { fuelCapacity = value; } }
    public double FuelFor1Km { get => fuelFor1Km; set { fuelFor1Km = value; } }
    public double CurrentFuel { get => currentFuel; set { currentFuel = value; } }

    public Car(string color, int year, string model, string brand, double fuelCapacity, 
        double fuelFor1Km) : base(color, year)
    {
        this.Model = model;
        this.Brand = brand;
        this.FuelCapacity = fuelCapacity;
        this.FuelFor1Km = fuelFor1Km;
        this.CurrentFuel = currentFuel;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Color:{Color} \n Year:{Year} \n Model:{Model} \n" +
            $" Brand:{Brand} \n Fuel Capacity:{FuelCapacity} \n Fuel For 1Km:{FuelFor1Km} \n CurrentFuel:{CurrentFuel}");
    }
    public void AddFuel(double amount)
    {
        if (amount <= fuelCapacity)
        {
            currentFuel += amount;
            Console.WriteLine($"Now current fuel is:{currentFuel}");
        }
        else
        {
            Console.WriteLine("Amount is too much");
        }
    }
}
