using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Menus
    {
        public void Start()
        {
            Calculation c = new Calculation();
            Arrays a = new Arrays();
            Intro i = new Intro();
            i.IntroScreen();
            try
            {
                Console.Write(":>");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice < 0 || choice > 3)
                {
                    Console.WriteLine("Invalid entry.");
                    Console.ReadLine();
                    Console.Clear();
                    i.IntroScreen();
                    Start();
                }
                switch (choice)
                {
                    case 1:
                        Input();
                        break;
                    case 2:
                        Console.Clear();
                        i.MiniScreenH();
                        c.Human();
                        break;
                    case 3:
                        Console.Clear();
                        i.MiniScreenC();
                        c.Computer();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong... {e}");
                Console.ReadLine();
                Start();
            }
        }

        public void Input()
            {
            Calculation c = new Calculation();
            Arrays a = new Arrays();
            Intro i = new Intro();

            Console.Clear();
            i.MiniScreenBB();
            Console.WriteLine("");
            Console.WriteLine("Enter a number between 1 and 10:");
            Console.Write(":>");
            try
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (x < 0 || x > 10)
                {
                    Console.WriteLine("Invalid entry.");
                    Console.ReadLine();
                    Console.Clear();
                    i.IntroScreen();
                    Start();
                }
                c.BisectionSearch(Arrays.baseArray, x);
                Console.ReadLine();

            }
            catch (Exception e)
            {
                Console.WriteLine($"Something went wrong... {e}");
                Console.ReadLine();
                Start();
            }
        }
    }
}
