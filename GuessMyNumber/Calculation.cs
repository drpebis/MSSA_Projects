using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessMyNumber
{
    class Calculation
    {
        public void BisectionSearch(int[] array, int x)
        {
            Menus m = new Menus();
            int min = 0;
            int max = array.Length - 1;
            int attempts = 1;

            while (min <= max)
            {
                int middle = min + ((max - min) / 2);

                if (array[middle] > x)
                {
                    max = middle - 1;
                    Console.WriteLine($"The new array to check is [{min},{max}].\n");
                    attempts++;
                }
                else if (array[middle] < x)
                {
                    min = middle + 1;
                    Console.WriteLine($"The new array to check is [{min},{max}].\n");
                    attempts++;
                }
                else
                {
                    Console.WriteLine($"The number is {x}. it was guessed on attempt number {attempts}\n");
                    Console.ReadLine();
                    Console.Clear();
                    m.Start();
                }
            }
        }
        public void Human()
        {
            Menus m = new Menus();
            int userGuess = -1;
            int attempts = 1;
            Random rnd = new Random();
            int cpuNumber = rnd.Next(0, 1000);
            Console.WriteLine("\n~The random number has been chosen by the computer~\n");
            while (userGuess != cpuNumber)
            {
                try
                {
                    Console.WriteLine($"Try to guess the number, this is attempt number: {attempts}.");
                    Console.Write(":>");
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    if (userGuess > 0 && userGuess < 1001)
                    {
                        Console.WriteLine($"The number selected is {userGuess}\n");

                        if (userGuess == cpuNumber)
                        {
                            Console.WriteLine($"You guessed right, the number is {userGuess}!\n");
                            Console.WriteLine($"It took you {attempts} attempts to get it right.");
                            Console.ReadLine();
                            Console.Clear();
                            m.Start();
                        }
                        else if (cpuNumber < userGuess)
                        {
                            Console.WriteLine($"You guessed too high\n");
                            attempts++;
                        }
                        else if (cpuNumber > userGuess)
                        {
                            Console.WriteLine($"You guessed too low.\n");
                            attempts++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.\n");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input\n");
                    Console.ReadLine();
                }

            }

        }
        public void Computer()
        {
            Menus m = new Menus();
            Console.WriteLine($"Please pick a number between 1 and 1000:");
            Console.Write(":>");
            int userNum = 0;
            try
            {
                userNum = Convert.ToInt32(Console.ReadLine());
                if (userNum > 0 && userNum < 1001)
                {
                    Console.WriteLine($"The number selected is {userNum}\n");
                    int leftNum = 0;
                    int rightNum = 1000;
                    int middleNum = -1;
                    int cpuAtempts = 1;
                    while (userNum != middleNum)
                    {
                        middleNum = leftNum + (rightNum - leftNum) / 2;

                        if (middleNum > userNum)
                        {
                            rightNum = middleNum;
                            Console.WriteLine($"The computer guessed {middleNum}.");
                            Console.WriteLine($"The new range to check is {leftNum} - {rightNum}.\n");
                            Console.WriteLine("Press enter...");
                            Console.ReadLine();
                            cpuAtempts++;
                        }
                        else if (middleNum < userNum)
                        {
                            leftNum = middleNum;
                            Console.WriteLine($"The computer guessed {middleNum}.");
                            Console.WriteLine($"The new range to check is {leftNum} - {rightNum}.\n");
                            Console.WriteLine("Press enter...");
                            Console.ReadLine();
                            cpuAtempts++;
                        }
                        else
                        {
                            Console.WriteLine($"The Computer guessed the number {userNum} right with {cpuAtempts} attempts.\n");
                            Console.ReadLine();
                            Console.Clear();
                            m.Start();
                        }
                    }

                }
                else
                {
                    Console.WriteLine("Please enter a valid number.\n");
                    Console.ReadLine();
                    Computer();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid Input\n");
                Console.ReadLine();
                Computer();
            }
        }
    }
}
