using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1005
    {
        static void Bee1005(string[] args)
        {

            double nota1 = double.Parse(Console.ReadLine()),
                              nota2 = double.Parse(Console.ReadLine());

            const double peso1 = 3.5;
            const double peso2 = 7.5;

            double somaDosPesos = peso1 + peso2;

            double media = ((nota1 * peso1) + (nota2 * peso2)) / somaDosPesos;

            Console.WriteLine("MEDIA = " + media.ToString("F5"));
        }
    }
}
