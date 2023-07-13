using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Manager : Employee
{
    public Manager(string name, string surname, double salary) : base(name, surname, salary)
    {

    }

    public override double CalculateBonus()
    {
        return salary * .15;
    }
}
