using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military_Unit
{
    class Dialogue
    {
        public void Run()
        {
            Characters c = new Characters();
            Tank tank = new Tank();
            Helicopter helicoper = new Helicopter();
            MachineGun machineGun = new MachineGun();
            Bazooka bazooka = new Bazooka();

            c.General();
            Console.WriteLine("General:\n\nMajor, we're surrounded by the enemy!");
            Console.ReadLine();
            Console.Clear();
            c.Major();
            Console.WriteLine("Major:\n\nThat sounds great! What's the next step, sir?");
            Console.ReadLine();
            Console.Clear();
            c.General();
            Console.WriteLine("General:\n\nNot sure, I have no idea what we have and what it does, so I need a refresher!");
            Console.ReadLine();
            Console.Clear();
            c.General();
            Console.WriteLine("General:\n\nMajor, what do tanks do?");
            Console.ReadLine();
            Console.Clear();
            c.Major();
            Console.Write("Major:\n\nSir, tanks ");
            tank.RunEngine("BOOOOOOOM!");
            Console.WriteLine("Let me fire this one up:");
            tank.LoadShell();
            tank.SwivelBarrel();
            tank.Fire();
            Console.ReadLine();
            Console.Clear();
            c.General();
            Console.WriteLine("General:\n\nSmashing! Now what's a helicopter?");
            Console.ReadLine();
            Console.Clear();
            c.Major();
            Console.Write("Major:\n\nSir, helicopters ");
            helicoper.RunEngine("wop wop wop wop wop wop");
            Console.WriteLine("I'll get this one ready:");
            helicoper.StartRotor();
            helicoper.CombMustache();
            helicoper.Music();
            Console.ReadLine();
            Console.Clear();
            c.General();
            Console.WriteLine("General:\n\nWhat fun! I read an article about a machine gun, what's that?");
            Console.ReadLine();
            Console.Clear();
            c.Major();
            Console.Write("Major:\n\nSir, machine guns ");
            machineGun.FireWeapon("BRAbabapapapapaapa");
            Console.WriteLine("Here's one in action:");
            machineGun.LoadWeapon();
            machineGun.AimWeapon();
            machineGun.Fireweapon();
            Console.ReadLine();
            Console.Clear();
            c.General();
            Console.WriteLine("General:\n\nWe've got them on the ropes, give me something to blow them up!");
            Console.ReadLine();
            Console.Clear();
            c.Major();
            Console.Write("Major:\n\nSir, bazookas ");
            machineGun.FireWeapon("SHHHHOOOOOOoooooooo ... BOOOM!");
            Console.WriteLine("Firing one on the enemy:");
            machineGun.LoadWeapon();
            machineGun.AimWeapon();
            machineGun.Fireweapon();
            Console.ReadLine();
            Console.Clear();
            c.General();
            Console.WriteLine("General:\n\nVery good! I'm bored now, let's go write ourselves up for awards and drink at the O'club!");
            Console.ReadLine();
            Console.Clear();
            c.Major();
            Console.Write("Major:\n\nSounds good, Sir!");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
