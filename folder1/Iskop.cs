using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_4
{
    class Iskop
    {
        private int ves;
        private double price;
        public void Init (int v, double p)
        {
            ves = v; price = p;
        }
        public void Read()
        {
            Console.Write("Вес: ");
            ves = Convert.ToInt32(Console.ReadLine());
            Console.Write("Цена: ");
            price = Convert.ToDouble(Console.ReadLine());
        }
        public void Display()
        {
            Console.WriteLine("Вес: " + ves + ", цена: " + price);
        }
        public double stoim()
        {
            return ves * price;
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
    }
}
