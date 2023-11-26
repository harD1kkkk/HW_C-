using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class OnlineOrder :
        Order
    {
        public string Address { get; set; }

        public OnlineOrder(int number, double amount, string address) : base(number, amount)
        {
            Address = address;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine("Delivery address: " + Address);
        }

        public void TrackStatus()
        {
            Console.WriteLine("Order status: in progress.");
        }
    }
}
