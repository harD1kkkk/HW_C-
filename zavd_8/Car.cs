using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Car :
        Vehicle
    {
        public int Doors { get; set; }

        public Car(string brand, int year, int doors) : base(brand, year)
        {
            Doors = doors;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Vehicle of brand: " + Brand + ",manufactured in: " + Year);
            Console.WriteLine("The car has doors: " + Doors);
        }

        public void StartEngine()
        {
            Console.WriteLine("The engine is started.");
        }
    }
}
