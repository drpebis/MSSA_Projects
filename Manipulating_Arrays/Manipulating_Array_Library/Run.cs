using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Run
    {
        Functions f = new Functions();
        ArraySamples a = new ArraySamples();
        public void RunProgram()
        {
            MenuMain();
            Console.WriteLine("Choose one:\n1. Counting, summing, computing a mean\n2. Reversing arrays\n3. Rotating arrays\n4. Sorting arrays\n5. Exit");
            Console.Write("\n:>");
            string choice = Console.ReadLine().ToString().ToLower();
            //while (choice != 1)
            //{ 
            //    Console.WriteLine("Invalid Input");
            //    Console.Write("\n:>");
            //    string choice = Console.ReadLine().ToString().ToLower();
            //} 
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    MenuPart1();
                    f.Part1();
                    StopClear();
                    break;
                case "2":
                    Console.Clear();
                    MenuPart2();
                    int[] array = f.Part2();
                    DisplayArray(array);
                    StopClear();
                    break;
                case "3":
                    Console.Clear();
                    MenuPart3();
                    f.Part3("left", 2, a.arrayA);
                    f.Part3("right", 2, a.arrayB);
                    f.Part3("left", 4, a.arrayC);
                    StopClear();
                    break;
                case "4":
                    Console.Clear();
                    MenuPart4();
                    int[] array2 = f.Part4(a.arrayC);
                    DisplaySort(array2);
                    StopClear();
                    break;
                case "5":
                    Environment.Exit(0);
                    break;
            }
            Console.Clear();
            RunProgram();
        }
        
        public void DisplayArray(int[] array)
        {
                Console.WriteLine(string.Join(",",array));
        }

        public void DisplaySort(int[] array)
        {
            Console.WriteLine("\nSorted array :");
            foreach (int aa in array)
                Console.Write(aa + " ");
        }
        public void StopClear()
        {
            Console.ReadLine();
            Console.Clear();
        }

        public void MenuMain()
        {
            Console.WriteLine("Manipulating Arrays");
            Console.WriteLine("-------------------\n");
        }
        public void MenuPart1()
        {
            Console.WriteLine("Part 1: Take the sum of an array and provide the mean of the entire array");
            Console.WriteLine("-------------------------------------------------------------------------\n");
        }

        public void MenuPart2()
        {
            Console.WriteLine("Part 2: Take an array and write it's input in reverse order back to the console.");
            Console.WriteLine("--------------------------------------------------------------------------------\n");
        }

        public void MenuPart3()
        {
            Console.WriteLine("Part 3: Rotate arrays either left or right based off of user input within a given number of places.");
            Console.WriteLine("---------------------------------------------------------------------------------------------------\n");
        }

        public void MenuPart4()
        {
            Console.WriteLine("Part 4: Take an unsorted integer array and print a sorted array.");
            Console.WriteLine("----------------------------------------------------------------\n");
            Console.WriteLine("This part uses Array C\n");
        }
    }
}
