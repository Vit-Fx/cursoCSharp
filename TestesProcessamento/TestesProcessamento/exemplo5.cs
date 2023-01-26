using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesProcessamento
{
    internal class exemplo5
    {
        static void Exemplo5(string[] args)
        {
            double a;
            int b;

            a = 5.0;
            b = (int) a; //É possível que haja perda de dados por ser um número double armazenado em uma variável int.

            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
