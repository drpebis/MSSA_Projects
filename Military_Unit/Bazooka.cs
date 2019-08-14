using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Bazooka : Weapons
    {
        public void LoadWeapon()
        {
            Console.WriteLine("Loading ammo");
        }

        public void Clearing()
        {
            Console.WriteLine("Clearing backblast area");
        }

        public virtual void Fireweapon()
        {
            Console.WriteLine("Firing!");
        }
    }
}
