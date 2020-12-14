using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Navodila:
//V programskem jeziku(C# ali Java) definirajte razred Točka, ki vsebuje naslednje lastnosti:
//private int x;
//private int y;
//Implementirajte tudi razred Krog, ki vsebuje naslednje lastnosti:
//private Tocka sredisce;
//private Tocka kroznica;
//Razred Krog ima tudi metodi obseg() in ploscina(). Metoda obseg() vrne obseg Kroga, medtem ko ploscina() vrne ploščino kroga. Pri izračunu uprabite Math.PI (ali primerno za C#) za aproksimacijo števila PI.
//Oba razreda imata konstruktor. Uporabo razredov pokažite v novem razredu z main metodo. Naredite instanco razreda Krog in izpišite rezultate metod obseg() in ploscina().
//(Avtor naloge FAMNIT, Programiranje 1)

namespace TockaInKrog
{
    class Program
    {
        static void Main(string[] args)
        {
            Tocka sredisce = new Tocka(1, 3);
            Tocka kroznica = new Tocka(3, 5);
            Tocka velikaKroznica = new Tocka(8, 8);

            Krog maliKrog = new Krog(sredisce, kroznica);            

            Console.WriteLine("Mali krog:");
            Console.WriteLine(sredisce);
            Console.WriteLine(kroznica);
            double polmerMaliKrog = Tocka.razdaljaMedTockama(sredisce, kroznica);
            Console.WriteLine("Obseg malega kroga: {0:f3}", maliKrog.obseg(polmerMaliKrog));
            Console.WriteLine("Ploščina malega kroga: {0:f3}", maliKrog.ploscina(polmerMaliKrog));
            Console.WriteLine();

            Krog velikKrog = new Krog(sredisce, velikaKroznica);

            Console.WriteLine("Velik krog:");
            Console.WriteLine(sredisce);
            Console.WriteLine(velikaKroznica);
            double polmerVelikiKrog = Tocka.razdaljaMedTockama(sredisce, velikaKroznica);
            Console.WriteLine("Obseg malega kroga: {0:f3}", velikKrog.obseg(polmerVelikiKrog));
            Console.WriteLine("Ploščina malega kroga: {0:f3}", velikKrog.ploscina(polmerVelikiKrog));

            Console.ReadKey(true);
        }
    }
}
