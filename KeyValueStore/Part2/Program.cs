using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        const int length = 5;
        Random r = new Random();
        int count = 0;

        public void HashSet()
        {
            HashSet<string> employees = new HashSet<string>();
            for (int i = 0; i < length; i++)
            {
                employees.Add(RandomName());
            }
            Console.WriteLine("\n\nPrinting from SortedList<T>:");
            Console.WriteLine("--------------------------------");
            foreach(string name in employees)
            {
                Console.Write($"Name: {name} ");
            }
        }
        public void SortedList()
        {
            SortedList<string, int> ages = new SortedList<string, int>();
            //for (int i = 0; i < length; i++)
            //{
            //    ages.Add(RandomName(), RandomAge());
            //}
            ages.Add("Bill", 30);
            ages.Add("James", 40);
            ages.Add("Jim", 50);
            ages.Add("Dave", 60);
            ages.Add("Rob", 70);
            Console.WriteLine("\n\nPrinting from SortedList<T>:");
            Console.WriteLine("--------------------------------");
            foreach(KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.Write($"Name: {name} Age: {age} ");
            }
        }
        public void Dictionary()
        {
            Dictionary<string, int> ages = new Dictionary<string, int>();
            //for (int i = 0; i < length; i++)
            //{
            //    ages.Add(RandomName(), RandomAge());
            //}
            ages.Add("Bill", 30);
            ages.Add("James", 40);
            ages.Add("Jim", 50);
            ages.Add("Dave", 60);
            ages.Add("Rob", 70);
            Console.WriteLine("\n\nPrinting from Dictionary<T>:");
            Console.WriteLine("--------------------------------");
            foreach(KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.Write($"Name: {name} Age: {age} ");
            }
        }
        public void Stack()
        {
            Stack<int> numbers = new Stack<int>();
            int[] arr = FillArray();

            foreach(int number in arr)
            {
                numbers.Push(number);
            }
            Console.WriteLine("\n\nPrinting from Stack<T>:");
            Console.WriteLine("---------------------------");
            foreach(int number in numbers)
            {
                Console.Write("{0} ", String.Join(" ", number));
            }

        }
        public void Queue()
        {
            Queue<int> numbers = new Queue<int>();
            int[] arr = FillArray();
            foreach(int number in arr)
            {
                numbers.Enqueue(number);
            }
            Console.WriteLine("\n\nPrinting from Queue<T>:");
            Console.WriteLine("---------------------------");
            foreach(int number in numbers)
            {
                Console.Write("{0} ", String.Join(" ", number));
            }
        }
        public void LinkedList()
        {
            LinkedList<int> numbers = new LinkedList<int>();
            int[] arr = FillArray();
            foreach(int number in arr)
            {
                numbers.AddFirst(number);
            }
            Console.WriteLine("\n\nPrinting from LinkedList<T>:");
            Console.WriteLine("----------------------------");
            for(LinkedListNode<int> node = numbers.First; node != null; node = node.Next)
            {
                int number = node.Value;
                Console.Write("{0} ", String.Join(" " , number));
            }

        }

        public int[] FillArray()
        {
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = r.Next(1, 100);
            }
            return arr;
        }
        public void List() //This method loads five random char values into the GenericList, then prints
            //each value out to the screen.
        {
            GenericList<char> genList = new GenericList<char>();
            for(int i = 0; i < length; i++)
            {
                genList.LoadList(Convert.ToChar((r.Next(97,122)))); //When using an int value inside of
                //Convert.ToChar, the int will be converted to it's unicode counterpart. In this case,
                //97 - 122 correspond to all regular letters in the English alphabet. 
            }
            Console.WriteLine("Printing from List<T>:");
            Console.WriteLine("----------------------");
            foreach(var x in genList.GenList)
            {
                Console.Write("{0} ", String.Join(" ", x));
            }
        }
        public string RandomName()
        {
            List<int> noDuplicates = new List<int>();
            Names n = new Names();

            int index = r.Next(0, 19);
            while (noDuplicates.Contains(index) == true)
            {
                index = r.Next(0, 19);
            }
            noDuplicates.Add(index);
            return n.names[index];
        }
        public int RandomAge()
        {
            //List<int> noDuplicates = new List<int>();
            //int age = r.Next(1, 100);
            //while (noDuplicates.Contains(age) == true)
            //{
            //    age = r.Next(1, 100);
            //}
            //noDuplicates.Add(age);
            count += 10;

            return count;
        }
        public void Run()
        {
            List();
            LinkedList();
            Queue();
            Stack();
            Dictionary();
            SortedList();
            HashSet();
        }
        static void Main(string[] args)
        {
            var p = new Program();
            p.Run();
            Console.ReadLine();
            

            
        }
    }
}
