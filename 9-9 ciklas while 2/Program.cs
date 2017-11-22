using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_ciklas_while_2
{
    class Program
    {
        static void Main(string[] args)
        {

            
            /*Padarykite skaičiuotuvą. Kiekvieno ciklo iteracijos metu vartotojas turi suvesti du skaičius.
            Iš šių skaičių turi būti grąžinami visi sudėties, skirtumo, sandaugos ir dalmens atsakymai išvedant 
            kartu ir atliekamus veiksmus. Pvz.:
            5 + 4 = 9
            5 - 4 = 1
            …
            Programa vykdoma tol, kol vartotojas nori atlikinėti skaičiavimus.*/

            var skaiciuoti = "t";
            while (skaiciuoti == "t")
            {
                Console.WriteLine("iveskite du skaicius");
                var a = Convert.ToInt32(Console.ReadLine());
                var b = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
                Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
                Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
                Console.WriteLine("{0} / {1} = {2}", a, b, (double)a / b);

                Console.WriteLine("ar dar skaiciuoti? t/n");
                skaiciuoti = Console.ReadLine();
            }
        }
    }
}