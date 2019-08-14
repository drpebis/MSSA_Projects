using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Weapons
    {
        public string FireWeapon(string gunNoise)
        {
            Console.WriteLine($"make the {gunNoise} sound, sir.");
            return gunNoise;
        }
    }
}
