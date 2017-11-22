using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("skaidre 137, uzduotis 1");
            {
                Console.WriteLine();
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }
            Console.WriteLine();

            Console.WriteLine("skaidre 137, uzduotis 2");
            Console.WriteLine();

            for (var i = 0; i < 15; i += 2)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.WriteLine("\n");
            Console.WriteLine("skaidre 137, uzduotis 3");
            Console.WriteLine();                  

            for (int i = 1; i < 20; i+=3)
            {
                Console.Write(i);
                Console.Write("[ ]");
            }

            Console.WriteLine("\n");
            Console.WriteLine("skaidre 137, uzduotis 4");
            Console.WriteLine();

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);

                Console.WriteLine();
                {

                }
            }

            Console.WriteLine();
            Console.WriteLine("skaidre 138, uzduotis 5");




            Console.WriteLine();
            Console.WriteLine("skaidre 138, uzduotis 7");

            var suma = 0;

            for (int i = 1; i < 100; i++)
            {
                suma += i;
            }
            Console.WriteLine("atsakymas: " + suma);
        }
    }
}