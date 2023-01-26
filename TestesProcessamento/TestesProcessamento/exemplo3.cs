using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestesProcessamento
{
    internal class exemplo3
    {
        static void Exemplo3(string[] args)
        {
            double b, B, h, area;

            b = 6.0;
            B = 8.0;
            h = 5.0;

            area = (b = B) / 2.0 * h;

            Console.WriteLine(area);

            Console.ReadLine();

        }
    }
}
