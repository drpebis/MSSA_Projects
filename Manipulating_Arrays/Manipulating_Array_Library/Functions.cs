using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    public class Functions
    {
        public void Part1()
        {
            Console.Write("Enter the array's size: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            double sum = 0, count = 0, mean = 0;
            int position = 1;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Input value for position {position}: ");
                array[i] = int.Parse(Console.ReadLine());
                position++;
            }
            foreach (int i in array)
            {
                sum += i;
                count++;
            }
            mean = sum / count;
            Console.WriteLine($"\nSum of the array / Array size = Mean:\n{sum} / {count} = {mean}");
        }
        public int[] Part2()
        {
            Console.Write("Array size: ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Input value: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < array.Length / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            return array;
        }

        public void Part3(string direction, int places, int[] array)
        {
            Console.WriteLine($"\nThe below array will be rotated {direction}, {places} times:\n");
            Console.Write("Original array: ");
            Console.WriteLine(string.Join(",", array));

            if (direction == "left")
            {
                for (int i = 0; i < places; i++)
                {
                    int temp = array[0];
                    for (int j = 1; j < array.Length; j++)
                    {
                        array[j - 1] = array[j];
                    }
                    array[array.Length - 1] = temp;
                }
                Console.Write("Rotated array: ");
                Console.WriteLine(string.Join(",", array));
            } else if (direction == "right")
            {
                int[] result = new int[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    result[i] = array[(i + (places + 1)) % array.Length];
                }
                Console.Write("Rotated array: ");
                Console.WriteLine(string.Join(",", result));
            }
        }

        public int[] Part4(int[] array)
        {
            int t;
            Console.WriteLine("Original array :");
            foreach (int aa in array)
                Console.Write(aa + " ");
            for (int p = 0; p < array.Length - 1; p++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        t = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = t;
                    }
                }
            }

            return array;
        }
    }
}



             

