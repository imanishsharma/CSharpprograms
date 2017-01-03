using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANISH_SHARMA
{
    class LEAP_YEARS
    {
        static void Main(string[] args)
        {
            int YEAR;
            Console.WriteLine("ENTER THE YEAR");
            YEAR = Convert.ToInt32(Console.ReadLine());
            if (YEAR % 4 == 0)
            {
                Console.WriteLine("YES, THIS YEAR IS LEAP YEAR");
            }
            else
            {
                Console.WriteLine("SoOrY...!!! THIS YEAR IS NOT A LEAP YEAR");
            }
            Console.ReadLine();
        }
    }
}


