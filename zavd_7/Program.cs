// See https://aka.ms/new-console-template for more information
namespace MySpace;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the start of the range:");
        int start = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the end of the range:");
        int end = int.Parse(Console.ReadLine());

        if (start > end)
        {
            Console.WriteLine("The start of the range must be less than or equal to the end!");
            return;
        }

        int a = 0;
        int b = 1;

        Console.WriteLine("Fibonacci numbers in the range: " + "Start: " + start + " End: " + end);
        while (a <= end)
        {
            if (a >= start)
            {
                Console.WriteLine(a);
            }
            int c = a + b;
            a = b;
            b = c;
        }
    }
}