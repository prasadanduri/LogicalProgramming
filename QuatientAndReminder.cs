using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPorgramming22
{
    public class QuatientAndReminder
    {
        public static void CalQueAndRem()
        {
            int dividend = 60, divisor = 7;
            
            int quotient = dividend / divisor;
            int reminder = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}",dividend,divisor);
            Console.WriteLine("Dividend:" + dividend + "Divisor:" + divisor);
            Console.WriteLine("Quotient:{0}",quotient);
            Console.WriteLine("Reminder:{0}",reminder);
            Console.ReadLine();

        }
    }
}
