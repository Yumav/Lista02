using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, C = 0, Soma = 0;

            Console.Write("Escreva um valor inteiro: ");
            N = int.Parse(Console.ReadLine());

            while (C <= N)
            {
                Soma = Soma + C;
                C++;
            }
            Console.WriteLine(Soma);
            Console.ReadLine();
        }
    }
}
