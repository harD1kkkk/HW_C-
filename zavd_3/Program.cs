// See https://aka.ms/new-console-template for more information
namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> ints = new List<int>(5);
            try
            {

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Enter numbers!: ");
                    int r = Int32.Parse(Console.ReadLine());
                    ints.Add(r);
                    Console.WriteLine(" ");

                    Console.Write("Your Entered number: ");
                    Console.Write(r);
                    Console.WriteLine(" ");
                }

                foreach (int i in ints)
                {
                    Console.Write("Your numbers before: "); Console.WriteLine(i); Console.WriteLine(" ");
                }
                for (int i = 5; i > 0; i--)
                {
                    Console.Write("Your numbers after: "); Console.WriteLine(i); Console.WriteLine(" ");
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

