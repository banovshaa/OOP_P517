using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Employee
{
    public string name;
    public string surname;
    public double salary;

    public Employee(string name, string surname, double salary)
    {
        this.name = name;
        this.surname = surname;
        this.salary = salary;
    }
    public virtual double CalculateBonus()
    {
        return salary * 0.1;
    }
}
