using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1006
    {
        static void Bee1006(string[] args)
        {

            double nota1 = double.Parse(Console.ReadLine()),
                               nota2 = double.Parse(Console.ReadLine()),
                               nota3 = double.Parse(Console.ReadLine());

            const int peso1 = 2;
            const int peso2 = 3;
            const int peso3 = 5;

            double somaDosPesos = peso1 + peso2 + peso3;

            double media = ((nota1 * peso1) + (nota2 * peso2) + (nota3 * peso3)) / somaDosPesos;

            Console.WriteLine("MEDIA = " + media.ToString("F1"));
        }
    }
}
