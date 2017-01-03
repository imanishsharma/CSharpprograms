using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Numbers
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("ENTER THE NUMBER YOU WANT TO CHECK AN EVEN OR ODD NUMBER");
            number = Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("THE NUMBER IS EVEN");
            }
            else
            {
                Console.WriteLine("THE NUMBER IS ODD");
            }
            Console.ReadLine();
        }
    }
}

