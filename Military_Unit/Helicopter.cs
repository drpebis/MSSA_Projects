using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Helicopter : Vehicles
    {
        public void StartRotor()
        {
            Console.WriteLine("Starting rotors");
        }

        public void CombMustache()
        {
            Console.WriteLine("Pilots mustache's are combed");
        }

        public virtual void Music()
        {
            Console.WriteLine("Top Gun music loaded and ready!");
        }
    }
}
