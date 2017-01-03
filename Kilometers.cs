using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Kilometers
    {
        static void Main(string[] args)
        {
            int kilometer;
            int meters;
            int centimeters;
            Console.Write("ENTER KILOMETER :-)");
            kilometer = Convert.ToInt32(Console.ReadLine());
            meters = kilometer * 1000;
            centimeters = kilometer * 100000;
            Console.WriteLine("METERS IN " + kilometer + " KM is:" + meters + " meters &  cnetimeters in " + kilometer + " KM is: " + centimeters+" Centimeters");
            Console.ReadLine();
        }
    }
}
