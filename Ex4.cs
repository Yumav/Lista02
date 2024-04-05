using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardec
            int C1;

            //Operacional
            for (C1 = 0;C1 <= 100000; C1 += 1000)
            {
                Console.Write(C1+", ");
            }
            Console.ReadLine();
        }
    }
}
