using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1002
    {
        static void Bee1002(string[] args)
        {
            double A, n, raio;

            n = 3.14159;

            raio = Double.Parse(Console.ReadLine());

            A = n * (Math.Pow(raio, 2));

            Console.WriteLine("A=" + A.ToString("F4"));
        }

    }
}
