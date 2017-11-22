using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_2_uzduotis
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Susikurkite kintamąjį žmogaus amžiui nusakyti, išveskite į ekraną tekstą su šiuo amžiumi: 
             * “Įvestas amžius: {amžius}”. Tarp {} nurodytas kintamasis, kurio reikšmė toje vietoje turi būti 
             * įstatyta.*/

            var metai = 39;
            Console.WriteLine("Ivestas amžius: " + metai);
            Console.WriteLine("ivestas amzius {0}", metai);
        }
    }
}
