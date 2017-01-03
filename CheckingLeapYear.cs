using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class LeapYears
    {
        static void Main(string[] args)
        {
            int year;
            Console.WriteLine("ENTER THE YEAR");
            year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
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


