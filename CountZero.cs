using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class CountZero
    {
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            try
            {
                calc.DoAverage();
            }
            catch (CountIsZeroException e)
            {
                Console.WriteLine("count is zero exception on :{0}",e.Message);
            }
            Console.ReadLine();
        }
    }
}
public class CountIsZeroException : ApplicationException
{
public CountIsZeroException(string message): base(message)
{
}
}
public class Calculate
{
int sum = 0;
int count = 0;
float average;
public void DoAverage()
{
if (count ==0)
throw (new CountIsZeroException("Zero count in DoAverage"));
else
average = sum/count;
}
}

