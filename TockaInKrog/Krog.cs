using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TockaInKrog
{
    class Krog
    {
        //lastnosti
        private Tocka sredisce;
        private Tocka kroznica;

        //pretvorbeni konstruktor
        public Krog(Tocka Sredisce, Tocka Kroznica)
        {
            sredisce = Sredisce;
            kroznica = Kroznica;
        }

        //metodi obseg() in ploscina()
        public double obseg(double polmer)
        {
            return 2 * Math.PI * polmer;
        }
        public double ploscina(double polmer)
        {
            return Math.PI * Math.Pow(polmer, 2);
        }        
    }
}
