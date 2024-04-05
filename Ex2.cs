using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //VarDec
            int C1, C2=1, C3=1;

            //Primeira Volta
            for (C1 = 1; C1 >= 1 && C1 <= 100; C1++)
            {
                Console.WriteLine(C1);       
            }

            while (C2 >= 1 && C2 <= 100)
            {
                Console.WriteLine(C2);
                C2++;
            }
            while (C3 >= 1 && C3 <= 100)
            {
                Console.WriteLine(C3);
                C3++;
            }
            Console.ReadLine();

        }
    }
}
