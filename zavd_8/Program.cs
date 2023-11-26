// See https://aka.ms/new-console-template for more information
namespace MySpace;
using ConsoleApp8;

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car("BMW", 2023, 4);
        Car car2 = new Car("Mercedes-Benz", 2022, 2);
        Motorcycle moto1 = new Motorcycle("Toyota", 2020, 30.2);
        Motorcycle moto2 = new Motorcycle("Jaguar", 2017, 29.5);

        car1.ShowInfo();
        car2.ShowInfo();
        moto1.ShowInfo();
        moto2.ShowInfo();

        car1.StartEngine();
        car2.StartEngine();
        moto1.Wheelie();
        moto2.Wheelie();
    }
}