using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardec
            int C=10;

            //Contagem
            while(C>=0 && C <= 10)
            {
                Console.Write(C + ", ");
                C = C - 1;
            }
            if (C >= -1)
                Console.WriteLine("Fim!");
            Console.ReadLine();
        }
    }
}
