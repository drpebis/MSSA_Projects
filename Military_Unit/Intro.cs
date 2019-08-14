using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Military_Unit
{
    class Intro
    {
        public void StartIntro()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       ╔════════════════════════════════════╗");
            Console.WriteLine("                                       ║        The following is a          ║");
            Console.WriteLine("                                       ║      simualted dramatization       ║");
            Console.WriteLine("                                       ║     of two military officers...    ║");
            Console.WriteLine("                                       ╚════════════════════════════════════╝");
            Thread.Sleep(4000);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       ╔════════════════════════════════════╗");
            Console.WriteLine("                                       ║       surrounded by an enemy       ║");
            Console.WriteLine("                                       ║       while they attempt to        ║");
            Console.WriteLine("                                       ║     formulate a counterattack      ║");
            Console.WriteLine("                                       ╚════════════════════════════════════╝");
            Thread.Sleep(3000);
            Console.Clear();
        }
        public void End()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                       ╔════════════════════════════════════╗");
            Console.WriteLine("                                       ║                                    ║");
            Console.WriteLine("                                       ║               ~Fin~                ║");
            Console.WriteLine("                                       ║                                    ║");
            Console.WriteLine("                                       ╚════════════════════════════════════╝");
            Console.ReadLine();

        }
    }
}
