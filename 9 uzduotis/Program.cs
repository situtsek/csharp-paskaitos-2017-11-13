using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iveskite tris skaicius");
            var a = Convert.ToInt32(Console.ReadLine());
            var b = Convert.ToInt32(Console.ReadLine());
            var c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("maziausias skaicius:");

            if (a < b && a > c)
            {
                Console.WriteLine(a);
            }
            else if (b < c && b < c)
            {
                Console.WriteLine(b);
            }
            else if (c < a && c < b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("abu skaiciai lygus");



            }
        }
    }
}