using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, C = 0;

            Console.Write("Escreva um valor inteiro: ");
            N = int.Parse(Console.ReadLine());

            if (N >= 0)
            {
                while (C <= N)
                {
                    Console.WriteLine(C);
                    C++;
                }
            }
            Console.ReadLine();
            
        }
    }
}
