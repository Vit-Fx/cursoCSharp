using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1010
    {
        static void Bee1010(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int cod = int.Parse(vet[0]);
            int num = int.Parse(vet[1]);
            double val = double.Parse(vet[2]);

            string[] vet2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(vet2[0]);
            int num2 = int.Parse(vet2[1]);
            double val2 = double.Parse(vet2[2]);


            double calc = num * val;
            double calc2 = num2 * val2;

            double result = calc + calc2;

            Console.WriteLine("Valor a pagar: R$ " + result.ToString("F2"));
        }
    }
}
