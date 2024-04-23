using System;

namespace L.R_N4
{
    class Program
    {
        static void Main(string[] args)
        {
            string Familiya; int God, Oklad;
            Console.Write("Введите фамилию: "); Familiya = Console.ReadLine();
            Console.Write("Введите оклад: "); Oklad = int.Parse(Console.ReadLine());
            Console.Write("Введите год поступления на службу: "); God = int.Parse(Console.ReadLine());
            Rabotnik Rabotnik1 = new Rabotnik(Familiya, Oklad, God);
            Console.WriteLine(Rabotnik1.ToString() + ".\n");
            int n, b;
            Console.Write("Введите кол-во работников: "); n = int.Parse(Console.ReadLine());
            Console.Write("Введите, сколько дней прошло с начала года: "); b = int.Parse(Console.ReadLine());
            Rabotnik[] Rabotniki = new Rabotnik[n];
            int stazh = 0, koldnei = 0;
            for (int i = 0; i < n; i++)
            {
                Rabotniki[i] = new Rabotnik();
                Console.Write("Введите фамилию: "); Familiya = Console.ReadLine();
                Console.Write("Введите оклад: "); Oklad = int.Parse(Console.ReadLine());
                Console.Write("Введите год поступления на службу: "); God = int.Parse(Console.ReadLine());
                Rabotniki[i].setFamiliya(Familiya);
                Rabotniki[i].setOklad(Oklad);
                Rabotniki[i].setGod(God);
                stazh = Rabotniki[i].stazh(stazh);
                koldnei = Rabotniki[i].koldnei(koldnei, b);
                if ((stazh % 10 >=5) || (stazh % 10 == 0) || ((stazh % 100 >= 10) && (stazh % 100 <= 20))) Console.WriteLine(Rabotniki[i].ToString() + ", имеет стаж " + stazh + " лет. После года поступления работника на службу прошло " + koldnei + " дней.\n");
                else if (stazh % 10 == 1) Console.WriteLine(Rabotniki[i].ToString() + ", имеет стаж " + stazh + " год. После года поступления работника на службу прошло " + koldnei + " дней.\n");
                else Console.WriteLine(Rabotniki[i].ToString() + ", имеет стаж " + stazh + " года. После года поступления работника на службу прошло " + koldnei + " дней.\n");
                koldnei = 0;
            }
        }
    }
}
