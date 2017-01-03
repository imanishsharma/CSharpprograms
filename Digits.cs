using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YOUR_JOURNALIST
{
    class Digits
    {
        static void Main(string[] args)
        {
            int num;
            int sum = 0; 
            int r;
            Console.WriteLine("Enter a Number : ");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number is:" +sum);
            Console.ReadLine();

        }
    }
}
