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
            int C=0,Soma=0;
            while(C<=50)
            {
                if (C % 2 == 0)
                    Soma=Soma + C;
                C++;
            }
            Console.WriteLine(Soma);
            Console.ReadLine();
        }
    }
}
