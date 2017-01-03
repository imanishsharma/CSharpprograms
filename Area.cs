using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MANISH_SHARMA
{
    class AREA
    {
        static void Main(string[] args)
        {
            float a, b, ar;
            Console.WriteLine("ENTER THE FIRST NUMBER:-)");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER THE SECOND NUMBER");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENTER 1 FOR FIND THE AREA OF RECTANGLE");
            Console.WriteLine("ENTER 2 FOR FIND THE AREA OF SQUARE");
            Console.WriteLine("ENTER YOUR CHOICE (1-2)");
            int ch = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    ar = a * b;
                    Console.WriteLine("AREA OF RECTANGLE IS:/n");
                    Console.WriteLine(ar);
                    break;
                case 2:
                    ar = a * a;
                    Console.WriteLine("AREA OF SQUARE IS: /n");
                    Console.WriteLine(ar);
                    break;
                default:
                    Console.WriteLine("WRONG CHOICE :-( ");
                    break;
            }
            Console.ReadLine();
        }
    }
}
                    
            
               
                   

            
            







