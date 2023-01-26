using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1017
    {
        static void Bee1017(string[] args)
        {
            double tempoGasto = double.Parse(Console.ReadLine()),
                   velocidadeMedia = double.Parse(Console.ReadLine());

            const int km = 12;

            double result = velocidadeMedia * tempoGasto / km;

            Console.WriteLine(result.ToString("F3"));
        }
    }
}
