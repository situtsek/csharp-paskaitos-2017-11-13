using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SARASAI
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> skaiciai = new List<int>();

            var rnd = new Random();

            var kiekSugeneruoti = rnd.Next(1, 101); // [1-100]

            for (int i = 0; i < kiekSugeneruoti; i++)
            {
                skaiciai.Add(rnd.Next(1, 101));
                Console.WriteLine(skaiciai[i] + " ");
            }

            Console.WriteLine("maziausias skaicius: " + skaiciai.Min());
            Console.WriteLine("didziausias skaicius: " + skaiciai.Max());

            var vidurkis = skaiciai.Average();
            Console.WriteLine("vidurkis: " + skaiciai.Average());

            var zemesniuUzVidurki = 0;

            foreach (var skaicius in skaiciai)
            {
                if (skaicius < vidurkis)
                {
                    zemesniuUzVidurki++;
                    
                }

                var lyginiuSkaiciuSuma = 0;
                Console.WriteLine("skaiciuSuma: " + skaiciai.Sum());
                foreach (var lyginis in skaiciai)
                {
                    if (skaicius == lyginis);
                }
                lyginiuSkaiciuSuma++;


            }


        }
    }
}
