using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1004
    {
        static void Bee1004(string[] args)
        {
            int a, b, PROD;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            PROD = a * b;

            Console.WriteLine("PROD = " + (PROD));
        }
    }
}
