using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1014
    {
        static void Bee1014(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            double litro = double.Parse(Console.ReadLine());

            double calc = km / litro;

            Console.WriteLine(calc.ToString("F3") + " km/l");
        }
    }
}
