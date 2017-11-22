using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_ciklas_while
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Liepkite vartotojui įvesti teigiamą skaičių. Ciklo pagalba šį skaičių išvesti mažėjimo 
            tvarka iki kol jis pasieks 0. Pvz.: 5 4 3 2 1. Kiekvieną kartą išvesti skirtingose eilutėse.*/


            Console.WriteLine("Iveskite teigiama skaiciu");
            var a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                while (a > 0)
                {
                    Console.WriteLine(a);
                    a--;

                }
            }
            else { Console.WriteLine("Skaicius neigiamas"); }
        }

    }
}
