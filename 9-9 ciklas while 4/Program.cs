using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_ciklas_while_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var tekstas = "";
            tekstas += "zodis";
            tekstas += "tekstas";
            Console.WriteLine(tekstas);*/

            /*Sukurkite string tipo kintamąjį. 
            Prie jo vis pridėkite vartotojo įrašomus skirtingus žodžius. 
            Tačiau jei vartotojas įrašytų “exit” - baigti ciklą. 
            Baigus vykdyti ciklą turi būti išvestas string kintamasis prie kurio vis buvo 
            pridedami skirtingi žodžiai.*/


        var rezultatas = "";
        var ivedimas = "";

        while (ivedimas != "exit") // kol neivede exit
        {
        Console.Write("iveskite zodi arba exit: ");
        ivedimas = Console.ReadLine();

         if (ivedimas != "exit")
        {
        rezultatas += ivedimas + " ";
        }
        }
        Console.WriteLine(rezultatas);
        }
    }
}
