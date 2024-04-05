using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vardec
            int Contagem=1, R;

            //Print
            while (Contagem >= 1 && Contagem <= 5)
            {
                R = 3 * Contagem;
                Console.WriteLine("3X" + Contagem + "=" + R);
                Contagem++;
            }
            Console.ReadLine();
        }
    }
}
