using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_4_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("pasirinkimai");
            Console.WriteLine("1 vanduo");
            Console.WriteLine("2 kava");
            Console.WriteLine("3 arbata");
            var numeris = Convert.ToInt32(Console.ReadLine());

            switch (numeris)
            {
                case 1:
                    Console.WriteLine("pasirinkta vanduo");
                    break;
                case 2:
                    Console.WriteLine("pasirinkta kava");
                    break;
                case 3:
                    Console.WriteLine("pasirinkta arbata");
                    break;

            }





        }
    }
}
