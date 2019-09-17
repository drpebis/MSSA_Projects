using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GuessMyNumber
{
    public class Program
    {
        static bool RunValidateProperty(int x)
        {
            var m = new MenuOption();
            var context = new ValidationContext(m) { MemberName = "x" };
            var result = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(x, context, result);
            return isValid;
            //if (result.Any())
            //{
            //    Console.WriteLine(result[0].ErrorMessage);
            //}
        }

        static void Main(string[] args)
        {
            Menus m = new Menus();
            Intro i = new Intro();

            m.Start();

        }
    }
}
