using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class GenericClass<T>
    {
        const int length = 5;
        List<T> genericList = new List<T>();

        private void ListType()
        {
            for (int i = 0; i <= length; i++)
            {
                genericList[i] = new List<int>(i);
            }
            
        }
        private void LinkedType()
        {
            LinkedList<string> listvs = new LinkedList<string>();
            Console.WriteLine("---------LinkedList----------");
            foreach (string str in new string[5] { "First", "Second", "Third", "Fourth", "Fifth" })
            {
                listvs.AddFirst(str);
            }
            foreach (string str in listvs)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("");
        }
        private void QueueType()
        {
            Queue<int> queuevs = new Queue<int>();
            Console.WriteLine("----------Queue----------");
            foreach (int num in new int[5] { 1, 2, 3, 4, 5 })
            {
                queuevs.Enqueue(num);
                Console.WriteLine(num);
            }
            Console.WriteLine("");
        }
        private void StackType()
        {
            Console.WriteLine("--------Stack--------");
            Stack<string> stackvs = new Stack<string>();
            foreach (var str in new string[5] { "FirstNum", "SecondNum", "ThirdNum", "FourthNum", "FifthNum" })
            {
                stackvs.Push(str);
            }
            foreach (var str in stackvs)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine("");
        }
        private void DictType()
        {
            Console.WriteLine("---------Dictionary---------");
            Dictionary<string, int> dictvs = new Dictionary<string, int>();
            dictvs.Add("First", 1);
            dictvs.Add("Second", 2);
            dictvs["Third"] = 3;
            dictvs["FOURTH"] = 4;
            dictvs.Add("FiFtH", 5);
            foreach (KeyValuePair<string, int> element in dictvs)
            {
                string str = element.Key;
                int num = element.Value;
                Console.WriteLine($"{str}, {num}");
            }
            Console.WriteLine("");
        }
        private void SortType()
        {
            Console.WriteLine("----------SortedList------------");
            SortedList<int, string> sortvs = new SortedList<int, string>();
            sortvs.Add(1, "First");
            sortvs.Add(2, "Second");
            sortvs.Add(3, "Third");
            sortvs.Add(4, "Fourth");
            sortvs[5] = "Fifth";
            foreach (KeyValuePair<int, string> el in sortvs)
            {
                int num = el.Key;
                string str = el.Value;
                Console.WriteLine($"{num}, {str}");
            }
            Console.WriteLine("");
        }
        private void HashType()
        {
            HashSet<string> hashvs = new HashSet<string>(new string[5] { "Element 1"
                , "Element 2"
                , "Element 3"
                , "Element 4"
                , "Element 5"
            });
            Console.WriteLine("---------HashSet----------");
            foreach (var hs in hashvs)
            {
                Console.WriteLine(hs);
            }
        }
        public void Run()
        {
            ListType();
            LinkedType();
            QueueType();
            StackType();
            DictType();
            SortType();
            HashType();
        }
    }
}
    }
}
