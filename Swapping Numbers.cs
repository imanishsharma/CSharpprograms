using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class SwappingNumbers
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int temp;
            Console.Write("\nEnter the First Number : ");
            num1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
            num2 =Convert.ToInt32(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping  : ");
            Console.Write("\nFirst Number : " + NUM_1);
            Console.Write("\nSecond Number : " + NUM_2);
            Console.ReadLine();
        }
    }
}
