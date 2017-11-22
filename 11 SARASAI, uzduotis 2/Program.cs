using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_SARASAI__uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pazymiai = new List<int>();

            Console.WriteLine("kiek pazymiu norite ivesti");
            var kiek = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < kiek; i++)
            {
                Console.WriteLine("iveskite (0) skaiciu: ", i+1);
                pazymiai.Add(Convert.ToInt32(Console.ReadLine()));
                }

            Console.WriteLine("didziausias: " + pazymiai.Max());
            Console.WriteLine("maziausias: " + pazymiai.Min());
            Console.WriteLine("vidurkis: " + pazymiai.Average());


            int[] pazymys = { 4, 7, 8, 10, 5 };
                var didziausias = pazymiai[0];

                foreach (var pazym in pazymiai)
                {
                    if (pazym > didziausias)
                    {
                        didziausias = pazym;
                    }
                }
            }
        }


    }
