using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardec
            int N = 0;
            double R = 0;

            Console.WriteLine("Digite 10 valores: ");

            for (int a = 1;a <= 10; a++)
            {
                Console.Write("Digite um valor: ");
                N = int.Parse(Console.ReadLine());

                R += N;
            }
            Console.WriteLine("A soma dos 10 valores é: " + R/10);
            Console.ReadLine();
        }
    }
}
