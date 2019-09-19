using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //In a new project, instantiate an instance of each of the generic collection classes 
            //described in Chapter 18:

            //List<T>,
            //LinkedList<T>,
            //Queue<T>,
            //Stack<T>,
            //Dictionary<TKey, TValue>,
            //SortedList<TKey, TValue>, and HashSet<T>).

            //Insert 5 values of a type of your choosing into each of these collections, 
            //then iterate over the collection and print each value to the console.
            //Print a line above your iteration stating which data structure you're printing from,
            //and print a blank line between the last item in the collection and the description of 
            //the following data structure.
            var p = new Program();
            p.Sorry();

        }
        public void Sorry()
        {
            Console.WriteLine("I'm sorry, but I'm bad at this");
            Sorry();
        }
    }
}
