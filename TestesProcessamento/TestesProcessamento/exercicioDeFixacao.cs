using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace TestesProcessamento
{
    internal class exercicioDeFixacao
    {
        static void Exercicio(string[] args)
        {
            //Exercício de fixação

            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quarto = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            double produto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");

            string[] vet = Console.ReadLine().Split(' ');
            string nm = vet[0];
            string idade = vet[1];
            string altura = vet[2];

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(produto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(nm);
            Console.WriteLine(idade);
            Console.WriteLine(altura);
        }

    }
}
