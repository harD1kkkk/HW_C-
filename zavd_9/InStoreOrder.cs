using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class InStoreOrder :
        Order
    {
        public string Store { get; set; }

        public string Payment { get; set; }

        public InStoreOrder(int number, double amount, string store, string payment) : base(number, amount)
        {
            Store = store;
            Payment = payment;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Store name: " + Store);
            Console.WriteLine("Payment method: " + Payment);
        }

        public void PrintReceipt()
        {
            Console.WriteLine("Your receipt");
        }
    }
}