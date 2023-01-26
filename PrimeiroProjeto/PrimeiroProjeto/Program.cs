using System;
using System.Data;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 10.35784;

            int y = 32;
            string z = "Maria";
            char w = 'F';

            Console.Write("Olá mundo!");
            Console.WriteLine("Bom dia!");
            Console.WriteLine("Até mais!");

            Console.WriteLine("Resultado " + x);
            Console.WriteLine("O valor do troco é " + x.ToString("F2") + " reais"); // Para limitar a quantidade de casas depois da vírgula
            Console.WriteLine(x.ToString("F4")); // Para limitar a quantidade de casas depois da vírgula

            Console.WriteLine(x.ToString("F2", CultureInfo.InvariantCulture)); // Para deixar por padrão o ponto como divisor de casas

            Console.WriteLine("A paciente " + z + " tem " + y + " anos e seu sexo é: " + w);

            Console.ReadLine();
        }
    }
}



