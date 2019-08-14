using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Tank : Vehicles
    {
        public void LoadShell()
        {
            Console.WriteLine("Loading Shell");
        }
        public void SwivelBarrel()
        {
            Console.WriteLine("Swivelling barrel");
        }
        public virtual void Fire()
        {
            Console.WriteLine("Ready to fire!");
        }
    }
}
