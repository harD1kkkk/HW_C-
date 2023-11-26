using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Order
    {
        public int Number { get; set; }
        public double Amount { get; set; }

        public Order(int number, double amount)
        {
            Number = number;
            Amount = amount;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine("Order " + Number + " for " + Amount + " UAH.");
        }
    }
}
