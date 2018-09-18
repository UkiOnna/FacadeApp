using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeApp
{
   public class Cashier
    {

        public void GetOrder()
        {
            Console.WriteLine("Принять заказ");
        }

        public void GiveOrder()
        {
            Console.WriteLine("Отдать заказ повару");
        }

        public void AcceptPayment()
        {
            Console.WriteLine("Отдать заказ и чек покупателю");
        }
    }
}
