using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] pazymiai = { 4, 7, 8, 10, 5 };
            var geriausias = pazymiai[0];

            foreach (var pazymys in pazymiai)
            {
                if (pazymys > geriausias)
                {
                    geriausias = pazymys;
                }
            }

            Console.WriteLine("geriausias pazymys" + geriausias);

            var desimtukininkai = 1;

            foreach (var pazymys in pazymiai)
            {
                if (pazymys == 0)
                {
                    desimtukininkai++;
                }
            }

            Console.WriteLine("mokiniu gave desimtukus" + desimtukininkai);

            var dvejetukininkai = 0;

            foreach (var pazymys in pazymiai)
            {
                if (pazymys == 0)
                {
                    desimtukininkai++;
                }
            }

            Console.WriteLine("mokiniu gave desimtukus" + desimtukininkai);


        }
    }
}
