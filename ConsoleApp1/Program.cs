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
            int[] parkingTickets = new int[5] { 1, 2, 5, 4, 3};
            int k = 0;
            int mostTickets = 0;
            for(k = 0; k < parkingTickets.Length; k++)
            {
                if(parkingTickets[k] > mostTickets)
                {
                    mostTickets = parkingTickets[k];
                }
            }


            Console.WriteLine(mostTickets);
            Console.ReadLine();
        }
    }
}
