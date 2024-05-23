using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR2_4
{
    class Rudnik
    {
        private String Nazv;
        private Iskop isk1 = new Iskop();
        private Iskop isk2 = new Iskop();
        private Iskop isk3 = new Iskop();
        private double zatrat;
        public void Init(String n, int v1, double p1, int v2, double p2, int v3, double p3, double z)
        {
            Nazv = n;
            isk1.Init(v1, p1);
            isk2.Init(v2, p2);
            isk3.Init(v3, p3);
            zatrat = z;
        }
        public void Read()
        {
            Console.Write("Название: ");
            Nazv = Console.ReadLine();
            Console.Write("Затраты: ");
            zatrat = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ископаемые:");
            isk1.Read();
            isk2.Read();
            isk3.Read();
        }
        public void Display()
        {
            Console.WriteLine("Название: " + Nazv + "\nЗатраты: " + zatrat);
            isk1.Display();
            isk2.Display();
            isk3.Display();
        }
        public double dohodnost()
        {
            return isk1.stoim() + isk2.stoim() + isk3.stoim() - zatrat;
        }
        public Iskop best()
        {
            if ((isk1.Price > isk2.Price) && (isk1.Price > isk3.Price))
            {
                Console.Write("Первое ископаемое самое ценное, и его цена равна ");
                return isk1;
            }
            else if ((isk2.Price > isk1.Price) && (isk2.Price > isk3.Price))
            {
                Console.Write("Второе ископаемое самое ценное, и его цена равна ");
                return isk2;
            }
            else
            {
                Console.Write("Третье ископаемое самое ценное, и его цена равна ");
                return isk3;
            }

        }
    }
}
