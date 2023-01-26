using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPropostos
{
    internal class Beecrowd1008
    {
        static void Bee1008(string[] args)
        {
            int numFunc, horasTrabalhadas;
            double valHora, salario;

            numFunc = int.Parse(Console.ReadLine());
            horasTrabalhadas = int.Parse(Console.ReadLine());
            valHora = double.Parse(Console.ReadLine());

            salario = horasTrabalhadas * valHora;

            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
