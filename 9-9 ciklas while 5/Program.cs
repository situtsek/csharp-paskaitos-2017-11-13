using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_ciklas_while_5
{
    class Program
    {
        static void Main(string[] args)

        {
            /*Liepkite vartotojui įvedinėti atsitiktinius skaičius. 
            Šį ciklą vykdyti tol, kol įvestas skaičius nesidalins iš 9.*/



            var skaicius = 1;

            while (skaicius % 9 != 0)
            {
                Console.WriteLine("iveskite skaiciu");
                skaicius = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("ivedete skaiciu kuris dalinasi is 9!");
        }
    }
}