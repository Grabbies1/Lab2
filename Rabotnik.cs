using System;
using System.Collections.Generic;
using System.Text;

namespace L.R_N4
{
    public class Rabotnik
    {
        private string familiya;
        private int oklad;
        private int god;
        public string getFamiliya() { return familiya;}
        public int getOklad() { return oklad; }
        public int getGod() { return god; }
        public void setFamiliya(string Familiya) { familiya = Familiya; }
        public void setOklad(int Oklad) { oklad = Oklad; }
        public void setGod(int God) { god = God; }
        public Rabotnik() { familiya = "-"; oklad = 0; god = 0; }
        public Rabotnik(string familiya, int oklad, int god) { this.familiya = familiya; this.oklad = oklad; this.god = god; }
        public int stazh(int Stazh) { Stazh = (2022 - god); return Stazh; }
        public int koldnei(int KolDnei, int b) { int a = god + 1; while(a < 2022) { if (a % 4 == 0) KolDnei += 366; else KolDnei += 365; a++; } if (god < 2022) KolDnei += b; return KolDnei; }
        public override String ToString() {
            return "Работник " + familiya + ", с окладом " + oklad + ", поступил на службу в " + god + " году";
        }
    }
}
