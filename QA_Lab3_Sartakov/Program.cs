using System;

namespace LR2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Rudnik r = new Rudnik();
            Console.WriteLine("Введите информацию о руднике:");
            r.Read();
            Iskop isk = new Iskop();
            int v = 300;
            double p = 1237.5;
            isk.Init(v, p);
            Console.WriteLine("Информация об отдельном ископаемом:");
            isk.Display();
            Console.WriteLine("Информация о руднике:");
            r.Display();
            Console.WriteLine("Стоимость отдельного ископаемого: " + isk.stoim());
            Console.WriteLine("Доходность рудника: " + r.dohodnost());
            Console.WriteLine("Выявление самого полезного ископаемого: ");
            isk = r.best();
            Console.WriteLine(isk.Price);
        }
    }
}
