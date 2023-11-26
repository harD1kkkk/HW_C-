// See https://aka.ms/new-console-template for more information
namespace Myspace;
using ConsoleApp9;

class Program
{
    static void Main(string[] args)
    {
        OnlineOrder onlineOrder1 = new OnlineOrder(99, 199, "Drohobych");
        OnlineOrder onlineOrder2 = new OnlineOrder(100, 399, "Kyiv");
        InStoreOrder inStoreOrder1 = new InStoreOrder(121, 200, "ABC", "cash");
        InStoreOrder inStoreOrder2 = new InStoreOrder(231, 321, "ZXC", "card");

        onlineOrder1.ShowInfo();
        onlineOrder1.TrackStatus();
        Console.WriteLine(" ");

        onlineOrder2.ShowInfo();
        onlineOrder2.TrackStatus();
        Console.WriteLine(" ");

        inStoreOrder1.ShowInfo();
        inStoreOrder1.PrintReceipt();
        Console.WriteLine(" "); 

        inStoreOrder2.ShowInfo();
        inStoreOrder2.PrintReceipt();
        Console.WriteLine(" ");
    }
}