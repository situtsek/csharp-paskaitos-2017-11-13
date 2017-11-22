using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_1_1_METODAI
{
    class Program
    {
        public object Algos { get; private set; }

        static void Main(string[] args)
        {
            List<double> atlyginimai = new List<double>();
            var programa = new Program();
            programa.Ivedimas(atlyginimai);
            programa.Isvedimas(atlyginimai);
            programa.AlgosVidurkis(atlyginimai);
            programa.DaugiauUzVidurki(atlyginimai);

            Console.WriteLine("Maziausia alga: " + programa.MaziausiaAlga(atlyginimai));
            Console.WriteLine("Didziausia alga: " + programa.MaziausiaAlga(atlyginimai));
            Console.WriteLine("Algos vidurkis: " + programa.AlgosVidurkis(atlyginimai));
            Console.WriteLine("Daugiau uz vidurki:" + programa.DaugiauUzVidurki(atlyginimai));

        }

        private void DaugiauAlguUzVidurki(List<double> atlyginimai)
        {
            throw new NotImplementedException();
        }

        public void Ivedimas(List<double> atlyginimai)
        {
            /* 1.paklausti kiek atlyginimu norima suvesti
             * 2. sukurti cikla nuo 0 iki nurodyto kiekio
             * 2.1. cikle isvesti "iveskite i-aji skaiciu"
             * 2.2. ivesti ir itelti i sarasa skaiciu */

            Console.WriteLine("kiek atlyginimu suvesti");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.Write("iveskite {0}-aji skaiciu: ", i + 1);
                atlyginimai.Add(Convert.ToDouble(Console.ReadLine()));


            }
        }

        public void Isvedimas(List<double> atgal)
        {
            foreach (var atl in atgal)
            {
                Console.Write("[{0}]", atl);

            }
            Console.WriteLine();
        }
        // randam maziausia alga
        // galim naudoti sarasas.Min() metoda

        public double MaziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Min();
        }

        public double DidziausiaAlga(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }
        public double AlgosVidurkis(List<double> atlyginimai)
        {
            return atlyginimai.Average();
        }
        public int DaugiauUzVidurki(List<double> atlyginimai)
        {
            var vidurkis = AlgosVidurkis(atlyginimai);
            var kiekis = 0;


            return 0; // veliau grazinti normalu atsakyma vietoj 0
        }
       


    }
}
