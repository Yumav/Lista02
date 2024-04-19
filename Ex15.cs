using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, C = 0;

            Console.Write("Escreva um valor inteiro: ");
            N = int.Parse(Console.ReadLine());
            
            if (N % 2 != 0)
            {
                while (C <= N)
                {
                    if (C % 2 != 0)
                    {
                        Console.WriteLine(C);

                    }
                    C++;
                }
            }
            Console.ReadLine();
        }
    }
}
