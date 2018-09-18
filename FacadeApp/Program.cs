using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Cook cook = new Cook();
            Cashier cashier = new Cashier();
            Facade client = new Facade(cashier, cook);
            client.MakeOrder();
            Console.ReadLine();
        }
    }
}
