using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int N,C=1;

            Console.Write("Escreva um valor inteiro: ");
            N = int.Parse(Console.ReadLine());

            while(C<=N)
            {
                if ((C % 2) != 0)
                    Console.WriteLine(C);
                C++;
            }
            Console.Read();
        }
    }
}
