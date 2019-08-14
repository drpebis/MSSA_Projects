using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Vehicles
    {
        public string RunEngine(string runNoise)
        {
            Console.WriteLine($"make the {runNoise} sound, sir.");
            return runNoise;
        }
    }
}
