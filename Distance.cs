using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Distance
    {
        int dist;
        public Distance(int d)
        {
            this.dist = d;
        }
        public static Distance operator +(Distance d1, Distance d2)
        {
            return new Distance(d1.dist + d2.dist);
        }
        public void showDistance()
        {
            Console.WriteLine(dist);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Distance d1 = new Distance(3);
            Distance d2 = new Distance(10);
            Distance d3;
            d3 = d1 + d2;
            d3.showDistance();
            Console.ReadLine();
        }
    }
}
