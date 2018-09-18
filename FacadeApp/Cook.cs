using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeApp
{
   public class Cook
    {

        public void TakeOrder()
        {
            Console.WriteLine("Принять заказ кассира");
        }

        public void Cooking()
        {
            Console.WriteLine("Приготовить еду по заказу");
        }

        public void GiveFood()
        {
            Console.WriteLine("Отдать еду по заказу кассиру");
        }
    }
}
