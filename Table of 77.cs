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
            int num, i, result;
            num = 77;
            i = 1;
            do
            {
                result = num* i;
                Console.WriteLine("{0} x {1} = {2}", num, i, result);
                i++;
            }
            while (i <= 10);

            Console.ReadLine();
        }
    }
}

