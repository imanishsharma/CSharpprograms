using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOUR_JOURNALIST
{
    class KILOMETERS
    {
        static void Main(string[] args)
        {
            int Kilometer;
            int meters;
            int centimeters;
            Console.Write("ENTER KILOMETER :-)");
            Kilometer = Convert.ToInt32(Console.ReadLine());
            meters = Kilometer * 1000;
            centimeters = Kilometer * 100000;
            Console.WriteLine("METERS IN " + Kilometer + " KM is:" + meters + " meters &  cnetimeters in " + Kilometer + " KM is: " + centimeters+" Centimeters");
            Console.ReadLine();
        }
    }
}
