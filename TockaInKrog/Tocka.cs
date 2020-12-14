using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TockaInKrog
{
    class Tocka
    {
        //lastnosti
        private int x;
        private int y;

        //pretvorbeni konstruktor
        public Tocka(int X, int Y)
        {
            x = X;
            y = Y;
        }

        //metoda izpis
        public override string ToString()
        {
            return "Točka (" + x + "," + y + ")";
        }

        //metoda razdalja med dvema točkama
        public static double razdaljaMedTockama(Tocka sredisce, Tocka kroznica)
        {
            return Math.Sqrt(Math.Pow((kroznica.x - sredisce.x), 2) + Math.Pow((kroznica.y - sredisce.y), 2));
        }
    }
}
