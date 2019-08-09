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
            public Coords(Random coord) 
            {
                //Random coord = new Random(); 
                this.x = coord.NextDouble(); 
                this.y = coord.NextDouble(); 
            }
            public double Hypotenuse() => Math.Sqrt(((Math.Pow(x, 2) + (Math.Pow(y, 2)))));
            //{
            //    double x = this.x;
            //    double y = this.y;
            //    double hyp = Math.Sqrt(((Math.Pow(x, 2) + (Math.Pow(y, 2)))));
            //    return hyp;
            //}
        }
        public static void CreateArray(int num) 
        {
            Random coord = new Random();
            int length = num; 
            Coords[] array = new Coords[length]; 
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Coords(coord);

                if (array[i].Hypotenuse() <= 1)
                {
                    count++;
                }
            }
            double result = (count / length) * 4;
            double diff = Math.Abs(Math.PI - result);
            Console.WriteLine($"Step 4: {count}\nDifference: {diff}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Type an integer here: ");
            Console.Write(":>");
            int num = int.Parse(Console.ReadLine());
            CreateArray(num);
            CreateArray(10);
            CreateArray(100);
            CreateArray(1000);
            CreateArray(10000);
            Console.ReadLine();
        }
    }
}
