using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomeGuysSky_Library;

namespace SomeGuysSky
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Matic m = new SomeGuysSky_Library.Matic();
                Init i = new Init();

                //m.IntroCinematic();
                i.Run();
            }catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
