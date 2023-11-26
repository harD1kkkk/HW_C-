// See https://aka.ms/new-console-template for more information
namespace MySpace
{
    class Program
    {
        static void Main(string[] args)
        {
            int Max = 0;
            int Min = 9999;
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
                    Console.Write("Your numbers: "); Console.WriteLine(i); Console.WriteLine(" ");
                }
                foreach (int i in ints)
                {

                    if (Max < i)
                    {
                        Max = i;
                    }

                    if (Min > i)
                    {
                        Min = i;
                    }

                }
                Console.Write("Max: "); Console.WriteLine(Max); Console.WriteLine(" ");
                Console.Write("Min: "); Console.WriteLine(Min); Console.WriteLine(" ");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
