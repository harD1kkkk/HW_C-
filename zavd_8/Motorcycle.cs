using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8;

    internal class Motorcycle :
        Vehicle
{

    public double Power { get; set; }

    public Motorcycle(string brand, int year, double power) : base(brand, year)
    {
        Power = power;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("Vehicle of brand: " + Brand + ",manufactured in: " + Year);
        Console.WriteLine("The motorcycle has a power: " + Power);
    }

    public void Wheelie()
    {
        Console.WriteLine("The motorcycle does a wheelie.");
    }
}
