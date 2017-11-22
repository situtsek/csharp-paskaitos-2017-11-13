using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_9_Do_while_1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Pritaikyti praeitoje skaidrėje parodytą pavyzdį. 
            Susigalvoti kitą temą, kurioje išeitų panaudoti tris pasirinkimus (pvz.: 1 - šuo, 2 - katė, 
            3 - žiurkėnas). Kol vartotojas nesuves tinkamų duomenų tol vykdyti ciklą.*/


            int pasi;
            do
            {
                Console.WriteLine("1 - šuo, 2 - katė, 3 - žiurkėnas");
                pasi = Convert.ToInt32(Console.ReadLine());
                if (pasi < 1 || pasi > 3)
                { Console.WriteLine("Tokios varianto nera"); }

            } while (pasi < 1 || pasi > 3);
            Console.WriteLine("pasirinkimas:" + pasi);
        }
    }
}
 