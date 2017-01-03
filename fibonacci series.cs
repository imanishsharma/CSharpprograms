using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FibonacciSeries
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            num1 = num2 = 1;
            Console.WriteLine("{0}", num1);
            while (num2 < 200)
            {
                Console.WriteLine(num2);
                num2 += num1;
                num1 = num2 - num1;
            }
            Console.ReadLine();
        }
    }
}

