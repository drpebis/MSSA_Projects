using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GuessMyNumber
{
    class Menus
    {
        //[Range(0,10)]
        //public int x { get; set; }

        //public int X
        //{
        //    get
        //    {
        //        return this.x;
        //    }
        //    set
        //    {
        //        if (x < 0 || x > 10)
        //        {
        //            throw new ArgumentOutOfRangeException($"Value {this.X} not within parameters");
        //        }
        //        else
        //        {
        //            x = this.X;
        //        }
        //    }
        //}
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
                MenuOption m = new MenuOption();
                m.x = Convert.ToInt32(Console.ReadLine());
                //var context = new ValidationContext(m.x);
                //var result = new List<ValidationResult>();
                //var isValid = Validator.TryValidateObject(m.x, context, result);
                //if(result.Any())
                //{
                //    Console.WriteLine(result[0].ErrorMessage);
                //}
                if (m.x < 0 || m.x > 10)
                {
                    Console.WriteLine("Invalid entry.");
                    Console.ReadLine();
                    Console.Clear();
                    i.IntroScreen();
                    Start();
                }
                c.BisectionSearch(Arrays.baseArray, m.x);
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
