using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_MASYVAI
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] pazymiai = { 7, 8, 3, 9, 10 };

            var makes = new string[3];
            makes[0] = "audi";
            makes[1] = "lada";
            makes[2] = "kamaz";

            Console.WriteLine("masyvu dydziai");
            Console.WriteLine("pazymiai: " + pazymiai.Length);
            Console.WriteLine("markes: " + makes.Length);

            Console.WriteLine("pazymiu masyvo");
            Console.WriteLine("pirma reiksme: " + pazymiai.First());
            Console.WriteLine("paskutine reiksme: " + pazymiai.Last());

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine(i + i + ": ");
            //    skaiciai[i] = Convert.ToInt32(Console.ReadLine());


            //}
        }
    }
}