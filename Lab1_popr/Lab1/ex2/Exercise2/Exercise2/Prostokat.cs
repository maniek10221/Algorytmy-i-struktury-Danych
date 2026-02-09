using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2
{
    internal class Prostokat : IComparable
    {
        int szerokosc;
        int wysokosc;
        int pole;

        public Prostokat(int szerokosc, int wysokosc)
        {
            this.szerokosc = szerokosc;
            this.wysokosc = wysokosc;
            this.pole = this.szerokosc * this.wysokosc;
        }
        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            if (obj is Prostokat otherProstokat)
                return this.pole.CompareTo(otherProstokat.pole);
            else
                throw new ArgumentException("Object is not a Prostokat");
        }
        public override string ToString()
        {
            return $"Prostokat: {szerokosc} x {wysokosc}, Pole: {pole}";
        }

    }
}
