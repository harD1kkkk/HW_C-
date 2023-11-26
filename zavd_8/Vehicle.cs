using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Vehicle
    {
        public string Brand { get; set; }
        public int Year { get; set; }

        public Vehicle(string brand, int year)
        {
            Brand = brand;
            Year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Vehicle of brand: " + Brand + ",manufactured in: " + Year);

        }
    }
}