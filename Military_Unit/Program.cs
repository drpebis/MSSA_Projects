using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Program
    {
        static void Main(string[] args)
        {
            Intro i = new Intro();
            Dialogue d = new Dialogue();

            i.StartIntro();
            d.Run();
            i.End();
        }
    }
}
