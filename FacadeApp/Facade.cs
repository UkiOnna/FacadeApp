using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeApp
{
  public class Facade
    {
        Cashier cashier;
        Cook cook;

        public Facade(Cashier cash,Cook cooker)
        {
            cashier = cash;
            cook = cooker;
        }

        public void MakeOrder()
        {
            cashier.GetOrder();
            cashier.GiveOrder();
            cook.TakeOrder();
            cook.Cooking();
            cook.GiveFood();
            cashier.AcceptPayment();
            Console.WriteLine("Клиент обслужен");
        }
    }
}
