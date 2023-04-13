using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamshop
{
    public class Hamburger
    {
        public bool pan = true;
        public bool carne1 = true;
        public bool carne2 {  get; set; }
        public bool queso { get; set; }
        public bool bacon { get; set; }
        public bool lechuga { get; set; }
        public bool tomate { get; set; }
        public bool cebolla { get; set; }
        public int Hamcount()
        {
            int count = 0;

            if (pan) count++;
            if (carne1) count++;
            if (carne2) count++;
            if (queso) count++;
            if (bacon) count++;
            if (lechuga) count++;
            if (tomate) count++;
            if (cebolla) count++;

            return count;
        }
    }

    public class ThinBurger : Hamburger
    {
        public bool pan = false;
        public bool pan_integral = true;
        public int Thincount()
        {
            int bonus1 = 0;

            if (pan_integral) bonus1++;

            return bonus1;
        }
    }

    public class PremiumBurger : Hamburger
    {
        public bool carne2 = false;
        public bool queso = false;
        public bool bacon = false;
        public bool lechuga = false;
        public bool tomate = false;
        public bool cebolla = false;
        public bool papitas = true;
        public string bebida { get; set; }
        public int Highcount()
        {
            int bonus2 = 0;

            if (papitas) bonus2++;
            bonus2++; // (Bebida)

            return bonus2;
        }
    }
}
