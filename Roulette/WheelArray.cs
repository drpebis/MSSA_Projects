using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Roulette
{
    public class WheelArray
    {
       public int ballPosition { get; set; }
        //This method takes a random number which matches the wheel array and returns the result,
        //this simulates the ball falling into one of the bins in the roulette wheel.
        public int GetBallPosition(int[] wheel)
        {
            int result;
            Random r = new Random();
            ballPosition = r.Next(0, 37);
            if (ballPosition == 0)
            {
                result = wheel[ballPosition];
            }
            else
            {
                result = wheel[ballPosition - 1];
            }
            return result;
        }
        //This method takes the same value from above and determines the color of the bin that the ball
        //fell into
        public string GetBallColor(string[] color)
        {
            string resultC;
            if (ballPosition == 0)
            {
                resultC = color[ballPosition];
            }
            else
            {
                resultC = color[ballPosition - 1];
            }
            return resultC;
        }
        //This method takes an array and checks if the bin that the ball fell into is within the array
        //that is being checked. 
        public bool InColumn(int[] column)
        {
            for(int i = 0; i < column.Length-1; i++)
            {
                if(column[i] == ballPosition)
                {
                    return true;
                }
            }
            return false;
        }
        //all possible colors
        public string[] color = new string[38]
{
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Black",
            "Red",
            "Green",
            "Green",
};
        //all possible values
        public int[] wheelAll = new int[38] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 0, 00 };

        //public int[] wheelPart = new int[36] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };


        public int[] column1 = new int[12] { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
        public int[] column2 = new int[12] { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
        public int[] column3 = new int[12] { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };

        public int[] street1 = new int[3] { 1, 2, 3 };
        public int[] street2 = new int[3] { 4, 5, 6 };
        public int[] street3 = new int[3] { 7, 8, 9 };
        public int[] street4 = new int[3] { 10, 11, 12 };
        public int[] street5 = new int[3] { 13, 14, 15 };
        public int[] street6 = new int[3] { 16, 17, 18 };
        public int[] street7 = new int[3] { 19, 20, 21 };
        public int[] street8 = new int[3] { 22, 23, 24 };
        public int[] street9 = new int[3] { 25, 26, 27 };
        public int[] street10 = new int[3] { 28, 29, 30 };
        public int[] street11 = new int[3] { 31, 32, 33 };
        public int[] street12 = new int[3] { 34, 35, 36 };

    }
}
