using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monte_Carlo
{
    public class MonteCarlo
    {
        public struct Coords 
        {
            public double x;
            public double y;
            public Coords(double x, double y) 
            {
                this.x = x;
                this.y = y;
            }
            public Coords(Random rand) 
            {
                //Random coord = new Random(); 
                this.x = rand.NextDouble(); 
                this.y = rand.NextDouble(); 
            }
            public double Hypotenuse() => Math.Sqrt(((Math.Pow(x, 2) + (Math.Pow(y, 2)))));
            //{
            //    double x = this.x;
            //    double y = this.y;
            //    double hyp = Math.Sqrt(((Math.Pow(x, 2) + (Math.Pow(y, 2)))));
            //    return hyp;
            //}
        }
        public static void MonteCarloArray(int num) 
        {
            Console.WriteLine($"For an array the size of {num}:\n");
            Random rand = new Random();
            int length = num; 
            Coords[] array = new Coords[length]; 
            double count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Coords(rand);

                if (array[i].Hypotenuse() <= 1)
                {
                    count++;
                }
            }

            double result = (count / length) * 4;

            Console.WriteLine($"The count was: {count}\nThe result was: {result}\nThe difference between the result and Pi is: {Math.Abs(Math.PI - result)}\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the array? ");
            Console.Write(":>");
            int num = int.Parse(Console.ReadLine());
            MonteCarloArray(num);
            MonteCarloArray(10);
            MonteCarloArray(100);
            MonteCarloArray(1000);
            MonteCarloArray(10000);
            Console.ReadLine();
        }
    }
}
