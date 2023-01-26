using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesProcessamento
{
    internal class checklist
    {
        static void Checklist(string[] args)
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            char ch = Convert.ToChar(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = Convert.ToChar(vet[1]);
            int idade = Convert.ToInt32(vet[2]);
            double altura = Convert.ToDouble(vet[3], CultureInfo.InvariantCulture);


            Console.WriteLine("Você digitou " + n1);
            Console.WriteLine(ch);
            Console.WriteLine(n2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
