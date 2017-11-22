using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_METODAI
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            programa.Pasisveikinti();
            programa.Pasisveikinti("Kestutis");
            programa.Pasisveikinti("Kestutis", "Milutis");

            programa.Atsisveikinti();
            programa.Atsisveikinti("Kestutis");
            programa.Atsisveikinti("Kestutis", "Milutis");
            StatinisMetodas();

            var sumosats = programa.Suma(4, 5);
            Console.WriteLine(sumosats);

            Console.WriteLine(programa.Suma(7, 5));
            Console.WriteLine(programa.Skirtumas(7, 5));
            Console.WriteLine(programa.Sandauga(7, 5));
            Console.WriteLine(programa.Dalmuo(7, 5));

            Console.WriteLine("Iveskite du skaicius:");
            var pirmas = Convert.ToInt32(Console.ReadLine());
            var antras = Convert.ToInt32(Console.ReadLine());

            var suma = programa.Suma(pirmas, antras);
            var skirtumas = programa.Skirtumas(pirmas, antras);
            var sandauga = programa.Sandauga(pirmas, antras);
            var dalmuo = programa.Dalmuo(pirmas, antras);

            Console.WriteLine("{0} + {1} = {2}", pirmas, antras, suma);

            //var plotas = programa.Plotas(pirmas, antras);
           // var perimetras = programa.Perimetras(pirmas, antras);
            Console.WriteLine();
            


            //taip pat pasirasyti 2-3 atsisveikinimo metodo
            // variacijas ir jas

        }

        // rasyti cia
        /*
        pasiekiamumas tipas pavadinimas (parametrai)
        */
        void Pasisveikinti()
        {
            Console.WriteLine("Labas, Kestutis");
        }
        void Pasisveikinti(string vardas)
        {
        Console.WriteLine("Labas, " + vardas);
        }
        public void Pasisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Labas, " + vardas + " " + pavarde);

            Console.WriteLine();

        
            //taip pat pasirasyti 2-3 atsisveikinimo metodo
            // variacijas ir jas

        }

        void Atsisveikinti()
        {
            Console.WriteLine("Viso gero, Kestutis");
        }
        void Atsisveikinti(string vardas)
        {
            Console.WriteLine("Viso gero, " + vardas);
        }
        public void Atsisveikinti(string vardas, string pavarde)
        {
            Console.WriteLine("Viso gero, " + vardas + " " + pavarde);

            Console.WriteLine();
        }
        public static void StatinisMetodas()
        {
            Console.WriteLine("statinis metodas");
        }
        public int Suma(int a, int b)
        {
            return a + b;
        }
        public int Skirtumas(int a, int b)
        {
            return a - b;
        }
        public int Sandauga(int a, int b)
        {
            return a * b;
        }
        public double Dalmuo(int a, int b)
        {
            return (double)a / b;
        }

        /* papildoma uzduotis: paprasyti vartotojo dvieju staciakampio krastiniu, parasyti metodus: suskaiciuoti plota;
        suskaiciuoti perimetra. Gautus atsakymus isvesti;*/

        /*paprasyti vartotojo visu reikiamu duomenu, parasyti metoda trikampio plotui suskaiciuoti,
        gauta atsakyma issisaugoti i kintamaji, ji isvesti i ekrana*/

        

    }
}
