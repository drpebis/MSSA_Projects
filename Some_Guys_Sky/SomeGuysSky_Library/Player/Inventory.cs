using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeGuysSky_Library
{
    class Inventory
    {
        List<Items> items = new List<Items>();

        public Inventory(List<Items> inventory)
        {
            foreach (Items item in inventory)
            {
                items.Add(new Items(inventory));
            }
        }





    }
}
