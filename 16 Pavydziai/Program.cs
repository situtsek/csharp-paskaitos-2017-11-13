using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Pavydziai
{
    class Program
    {
        static void Main(string[] args)
        {
            var automobilis = new Automobilis("Audine", "A4", 2017, 2.2, 150, 3);
            automobilis.Isvedimas();

            var automobiliai = new List<Automobilis>
            {
                new Automobilis("BMW", "530D", 2000, 2.1, 20, 50),
                new Automobilis("Citroen", "C4", 2017, 1.6, 20, 50),
                new Automobilis("VW", "Touareg", 2007, 3.0, 20, 50),
                new Automobilis("Tesla", "500D", 2016, 0.0, 20, 50),
            };

            var programa = new Program();
            programa.Isvedimas(automobiliai);

            var naujausias = programa.NaujausiasAuto(automobiliai);
            Console.WriteLine("Naujausias auto:");
            naujausias.Isvedimas();

        } // main metodo pabaiga

        // visa automobiliu sarasa isvesti i ekrana
        public void Isvedimas(List<Automobilis> automobiliai)
        {
            foreach (var auto in automobiliai)
            {
                auto.Isvedimas();
            }
        }

        // naujausias automobilis
        public Automobilis NaujausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            // cia foreach

            foreach (var auto in automobiliai)
            {
                if (auto.Metai > laikinas.Metai)
                {
                    laikinas = auto;
                }
            }

            return laikinas;

        }

        // seniausias automobilis
        public Automobilis SeniausiasAuto(List<Automobilis> automobiliai)
        {
            var laikinas = automobiliai.First();

            // cia foreach

            foreach (var auto in automobiliai)
            {
                if (auto.Metai > laikinas.Metai)
                {
                    laikinas = auto;
                }
            }

            return laikinas;

        }





    }
}
    

