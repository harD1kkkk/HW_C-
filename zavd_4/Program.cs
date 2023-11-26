// See https://aka.ms/new-console-template for more information
namespace Myspace;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a six-digit number:");
        int num = Int32.Parse(Console.ReadLine());

        int reverse = 0;
        for (int i = 0; i < 6; i++)
        {
            reverse = reverse * 10 + num % 10;
            num /= 10;
        }
        Console.WriteLine("Reversed number: " + reverse);
    }
}
