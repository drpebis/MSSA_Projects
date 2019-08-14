using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class MachineGun : Weapons
    {
        public void LoadWeapon()
        {
            Console.WriteLine("Loading ammo");
        }

        public void AimWeapon()
        {
            Console.WriteLine("Aiming");
        }

        public virtual void Fireweapon()
        {
            Console.WriteLine("Firing");
        }
    }
}
