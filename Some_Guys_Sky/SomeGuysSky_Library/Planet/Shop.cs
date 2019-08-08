using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeGuysSky_Library
{
    class Shop
    {
        private List<Items> _marketPlace;

        public Shop()
        {
            PopulateMarketPlace();
        }

        public List<Items> GetAllItems()
        {
            var items = new List<Items>();
            items.AddRange(_marketPlace);
            return items;
        }

        private void PopulateMarketPlace()
        {
            _marketPlace = new List<Items>
            {
            new Items("Zen:", 30),
            new Items("RotWood:", 150),
            new Items("Iridium:", 400),
            new Items("Adamantite:", 550),
            new Items("VoidStone:", 950),
            new Items("Meteorite:",1000),
            new Items("FireStone:",1100),
            new Items("Plutonium:",1800),
            new Items("Magic Dust:",2500),
            new Items("Nanite",3000),
            new Items("GalaxyStone",8000),
            new Items("DarkMatter",20000)
            };
        }




    }
}
