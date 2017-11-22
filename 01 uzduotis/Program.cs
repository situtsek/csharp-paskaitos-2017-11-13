using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ivesti tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("pirmas lygus antram");
            }
            if (b == c)
            {
                Console.WriteLine("antras lygus treciam");
            }
            if (a > c)
            {
                Console.WriteLine("pirmas didesnis uz trecia");
            }
            if (b > c * 2)
            {
                Console.WriteLine("antras uz trecia dviguba");
            }
            if (a % 2 == 0)
            {
                Console.WriteLine("pirmas skaicius lyginis?");
            }
            if (b % 2 != 0)
            {
                Console.WriteLine("antras skaicius nelyginis?");
            }
            if (c > 0)
            {
                Console.WriteLine("trecias teigiamas?");
            }
            if (c < 0)
            {
                Console.WriteLine("trecias neigiamas?");
            }
            
        }
    }
}
