using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication	
{
    class Player
    {
        string playerName;
        int rank;
        public void printPlayerDetails()
        {
            Console.WriteLine("\n THE DETAILS OF THE TENNIS PLAYER IS:");
            Console.Write("NAME :");
            Console.WriteLine(TENNIS_PLAYER_NAME);
            Console.Write("RANK:");
            Console.Write(rank);
        }
        public void getPlayerDetails()
        {
            Console.WriteLine("\n THE DETAILS OF THE TENNIS PLAYER IS:");
            Console.WriteLine("ENTER TENNIS PLAYER NAME:");
            playerName = Console.ReadLine();
            Console.WriteLine("RANK");
            rank = Convert.ToInt32(Console.ReadLine());
        }
    }
}
    
     
       