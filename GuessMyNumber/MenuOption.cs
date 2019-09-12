using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GuessMyNumber
{
    public class MenuOption
    {
        [Range(0, 10)]
        public int x { get; set; }
    }
}
