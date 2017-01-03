using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Tables
    {
        static void Main(string[] args)
        {
            int number, i, result;
            Console.Write("ENTER A NUMBER \t");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n TABLE OF NUMBER");
            Console.WriteLine(number);
            Console.WriteLine(" IS :-)");
            for (i = 1; i <= 10; i++)
            {
                result = number * i;
                Console.WriteLine("{0} x {1} = {2}", number, i, result);
            }
            Console.ReadLine();
        }
    }
}
