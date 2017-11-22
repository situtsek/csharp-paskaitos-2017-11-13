using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_3_MASYVAI__192_skaidre__uzduotis_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] temperaturos = { 14.5, 18.5, 20.4, -30 };
            var zemiausia = temperaturos[0];

            foreach (var temperatura in temperaturos)
            {
                if (temperatura < zemiausia)
                {
                    zemiausia = temperatura;
                }
            }

            Console.WriteLine("zemiausia temperatura" + zemiausia);

            var auksciausia = temperaturos[0];

            foreach (var temperatura in temperaturos)
            {
                if (temperatura > auksciausia)
                {
                    auksciausia = temperatura;
                }
            }

            Console.WriteLine("auksciausia temperatura" + auksciausia);

            var suma = 0.0;

            foreach (var temp in temperaturos)
            {
                suma += temp;
            }

            var vidurkis = suma / temperaturos.Length;

            Console.WriteLine("vidurkis: " + vidurkis);

            var zemesniu_uz_vidurki_kiekis = 0;

            foreach (var temp in temperaturos)
            {
                if (temp < vidurkis)
                {
                    zemesniu_uz_vidurki_kiekis++;
                }
            }

            Console.WriteLine("zemesniu uz vidurki kiekis: " + zemesniu_uz_vidurki_kiekis);
        }
    }
}