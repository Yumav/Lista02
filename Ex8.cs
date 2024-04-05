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
            int N = 0, NMaior=int.MinValue, Nmenor=int.MaxValue;

            Console.WriteLine("Digite 10 valores: ");

            for (int a = 1;a <= 10; a++)
            {
                Console.Write("Digite um valor: ");
                N = int.Parse(Console.ReadLine());

                if (N <= Nmenor)
                {
                    Nmenor = N;   
                }

                if (N >= NMaior)
                {
                    NMaior = N;
                }


            }
            Console.WriteLine("O valor menor é: "+Nmenor);
            Console.WriteLine("O valor maior é: " + NMaior);
            Console.ReadLine();
        }
    }
}
