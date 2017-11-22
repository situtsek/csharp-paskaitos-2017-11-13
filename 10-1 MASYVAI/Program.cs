using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_MASYVAI
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

            Console.WriteLine("zemiausia temperatura");
            {

                var auksciausia = temperaturos[0];

                foreach (var temperatura in temperaturos)
                {
                    if (temperatura < auksciausia)
                    {
                        auksciausia = temperatura;

                    }
                }
                Console.WriteLine("auksciausia temperatura" + auksciausia);

            }
        }
    }
}