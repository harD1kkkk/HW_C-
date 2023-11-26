// See https://aka.ms/new-console-template for more information
using ConsoleApp5;

namespace MySpace;

class Program
{
    static void Main(string[] args)
    {

        Person person = new Person("Vitalik", 25);

        Console.WriteLine("Name: " + person.Name + ",age: " + person.Age);

        person.Age = 26;

        Console.WriteLine("Name: " + person.Name + ",age: " + person.Age);
    }
}