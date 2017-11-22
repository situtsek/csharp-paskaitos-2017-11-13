using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("gyvuno rusis");
            var gyvunas = Console.ReadLine();



            switch (gyvunas)
            {
                case "suo":
                    Console.WriteLine("buvo ivesta suo");
                    break;
                case "kate":
                    Console.WriteLine("buvo ivesta kate");
                    break;
                case "ziurkenas":
                    Console.WriteLine("buvo ivesta ziurkenas");
                    break;
                case "triusis":
                    Console.WriteLine("buvo ivesta triusis");
                    break;
                case "papuga":
                    Console.WriteLine("buvo ivesta papuga");
                    break;

            }
            }
    }
}
