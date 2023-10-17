using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshAlgo.algo
{
    internal class gcd
    {
        public static void gcd_cal(int number, int divisor)
        {
            int reminder = divisor;
            while (reminder != 0)
            {
                reminder = number % divisor;
                if (reminder == 0)
                {
                    break;
                }
                divisor = reminder;
            }
            Console.WriteLine(divisor);
        }
    }
}
