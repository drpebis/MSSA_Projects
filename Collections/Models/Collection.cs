using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Collections.Models
{
    public class Collection
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public decimal RateOfPay { get; set; }
        public decimal HoursWorked { get; set; }
        [DataType(DataType.Date)]
        public DateTime PayWeek { get; set; }

        public static string GetPay(decimal hoursWorked, decimal rateOfPay)
        {
            decimal totalPay;
            string pay;
            if (hoursWorked > 40)
            {
                totalPay = (((hoursWorked - 40) + rateOfPay / 2) + hoursWorked * rateOfPay);
            }
            else
            {
                totalPay = (hoursWorked * rateOfPay);
            }

            pay = totalPay.ToString("C");

            return pay;
        }

        public static string OverTime(decimal hoursWorked)
        {
            
            if (hoursWorked > 40)
            {
                return $"Yes,  {hoursWorked - 40} hours.";
            }
            return null;
        }
    }
}
