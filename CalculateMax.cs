using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateMax
{
    class CalculateMax
    {
        public int Max(int number1, int number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
        public float Max(float number1, float number2)
        {
            if (number1 > number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }
    }
    class MaxCalc
    {
        static int Main(string[] args)
        {
            CalculateMax Calc = new CalculateMax();
            Console.WriteLine("{0}", Calc.Max(5.4F, 8.6F));
            Console.WriteLine("{0}", Calc.Max(19, 12));
            Console.ReadLine();
            return 0;
        }
    }
}
