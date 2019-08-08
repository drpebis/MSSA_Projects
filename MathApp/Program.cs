using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_3C
{
    class Program1
    {
        static void Main(string[] args)
        {
            var prg1 = new Program1();
            prg1.calcT();
            Console.ReadLine();
        }
        public decimal calcT()
        {
            int i;
            decimal t = 6000, m = 6000;
            for (i = 1; i < 6; i++)
            {
                if (i != 1)
                {
                    t += (m * .02M);
                    Console.WriteLine($"For year {i} your tuition will be {t:C}");
                }
                else
                {
                    Console.WriteLine($"For year {i} your tuition will be {t:C}");
                }
            }
            return t;
        }
    }
}

