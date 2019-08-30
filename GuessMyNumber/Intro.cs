using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GuessMyNumber
{
    class Intro
    {
        public void IntroScreen()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("             ╔════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║       ______                        __  ___         _   __                __               ║");
            Console.WriteLine("             ║      / ____/_  _____  __________   /  |/  /_  __   / | / /_  ______ ___  / /_  ___  _____  ║");
            Console.WriteLine(@"             ║     / / __/ / / / _ \/ ___/ ___/  / /|_/ / / / /  /  |/ / / / / __ `__ \/ __ \/ _ \/ ___/  ║");
            Console.WriteLine("             ║    / /_/ / /_/ /  __(__  |__  )  / /  / / /_/ /  / /|  / /_/ / / / / / / /_/ /  __/ /      ║");
            Console.WriteLine(@"             ║    \____/\__,_/\___/____/____/  /_/  /_/\__, /  /_/ |_/\__,_/_/ /_/ /_/_.___/\___/_/       ║");
            Console.WriteLine("             ║                                        /____/                                              ║");
            Console.WriteLine("             ╚════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                                          Select one of the following options:");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("              1. Basic bisection algorithm: you enter an integer between 1 and 10, and the alogrithm will");
            Console.WriteLine("                 find it within an array.");
            Console.WriteLine("");
            Console.WriteLine("              2. Guess my Number(tm) - Human player: The compuer will choose a random number between ");
            Console.WriteLine("                 1 and 1000, your job is to guess what that number is!");
            Console.WriteLine("");
            Console.WriteLine("              3. Guess my Number(tm) - Computer player: The tables are turned! You choose a number between");
            Console.WriteLine("                 1 and 1000, and the computer will try to guess!");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public void MiniScreenBB()
        {
            Console.WriteLine("             ╔════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                         Guess My Number! (tm) -  Basic Bisection                           ║");
            Console.WriteLine("             ╚════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void MiniScreenH()
        {
            Console.WriteLine("             ╔════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                           Guess My Number! (tm) -  Human Player                            ║");
            Console.WriteLine("             ╚════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
        public void MiniScreenC()
        {
            Console.WriteLine("             ╔════════════════════════════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("             ║                         Guess My Number! (tm) -  Computer Player                           ║");
            Console.WriteLine("             ╚════════════════════════════════════════════════════════════════════════════════════════════╝");
        }
    }
}
