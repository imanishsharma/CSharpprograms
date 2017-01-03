using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CUSTOMER
{
    class CustomerDetails
    {
        static void Main(string[] args)
        {
            string customername;
            string address;
            int phonenumber;
            
            
            
                Console.WriteLine("ENTER THE NAME OF CUSTOMER");
                customername = Console.ReadLine();
                Console.WriteLine("ENTER THE ADDRESS OF CUSTOMER");
                address = Console.ReadLine();
                Console.WriteLine("ENTER THE PHONE NUMBER OF CUSTOMER");
                phonenumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("DETAILS OF CUSTOMER IS:-)");
                Console.Write("CUSTOMER NAME: ");
                Console.WriteLine(customername);
                Console.Write("ADDREES: ");
                Console.WriteLine(address);
                Console.Write("PHONE NO. : ");
                Console.WriteLine(phonenumber);
                Console.ReadLine();
            
                
        }
    }
}

            
            

           
         
            
            
                
            
               

        