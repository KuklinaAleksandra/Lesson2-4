using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string shop = "Брендированный электронный \n чек для отправки  ";
            string thing = "Футболка  ";
            int price = 500;
            int quantity = 3;
            int sum = price * quantity;
            double nds20 = sum * 0.2;
            Console.WriteLine( shop + "  \n" + thing + price + " x "+  quantity + " = " + sum + "  \n" + "НДС 20%              " + nds20);
            Console.WriteLine("  ");
            Console.ReadKey();
        }
    }
}
