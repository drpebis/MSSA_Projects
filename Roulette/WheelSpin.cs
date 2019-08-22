using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Roulette
{
    class WheelSpin
    {
        //this method adds a visual indicator that a 'wheel' is spinnning, plus a little suspense for the
        //player
        public void Spin()
        {
            Console.WriteLine("Spinning wheel... (|)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine("Spinning wheel... (/)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine("Spinning wheel... (-)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine(@"Spinning wheel... (\)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine("Spinning wheel... (|)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine("Spinning wheel... (/)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine("Spinning wheel... (-)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine(@"Spinning wheel... (\)");
            Thread.Sleep(300);
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            ClearCurrentConsoleLine();
            Console.WriteLine(@"Spinning wheel... (|)");
            Thread.Sleep(300);
        }
        //I got this code from https://stackoverflow.com/questions/8946808/can-console-clear-be-used-to-only-clear-a-line-instead-of-whole-console
        //this makes it so the wheel spinning animation takes place only over one single line
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }

    }
}
