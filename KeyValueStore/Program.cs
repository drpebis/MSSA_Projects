﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeyValueStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new MyDictionary();
            try
            {
                Console.WriteLine(d["Cats"]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                d["Cats"] = 42;
                d["Dogs"] = 17;
                Console.WriteLine($"{d["Cats"]}, {d["Dogs"]}");

                d["Cats"] = 56;
                d["Dogs"] = 29;
                Console.WriteLine($"{d["Cats"]}, {d["Dogs"]}");
                Console.ReadLine();
            }
        }
    }
}
