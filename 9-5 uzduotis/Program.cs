using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_5_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pasirinkimai");
            Console.WriteLine("1 stacionarus kompiuteris");
            Console.WriteLine("2 nesiojamas kompiuteris");
            Console.WriteLine("3 plancete");
            var numeris = Convert.ToInt32(Console.ReadLine());

            switch (numeris)
            {
                case 1:
                    Console.WriteLine("pasirinkta stacionarus kompiuteris");
                    break;
                case 2:
                    Console.WriteLine("pasirinkta nesiojamas kompiuteris");
                    break;
                case 3:
                    Console.WriteLine("plancete");
                    break;

            }
        }
    }
}
