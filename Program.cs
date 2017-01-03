using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryOverload
{
    class Calculator
    {
        public int number;
        public Calculator()
        {
            number = 0;
        }
        public Calculator(int n)
        {
            number = n;
        }
        public static Calculator operator +(Calculator Calc1, Calculator Calc2)
        {
            Calculator calc3 = new Calculator(0);
            calc3.number = Calc2.number + Calc1.number;
            return calc3;
        }
            public void display()
            {
                Console.WriteLine("{0}", number);
            }
    } 
    class CalNum
    {
        static int Main(string [] args)
        {
            Calculator num1 = new Calculator(100);
            Calculator num2 = new Calculator(50);
            Calculator num3 = new Calculator();
            num3 = num1 + num2;
            num1.display();
            num2.display();
            num3.display();
            Console.ReadLine();
            return 0;
        }
    }
}