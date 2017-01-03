using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace worldpuzzle
{
    class program
    {
        string[] result = new string[] { "ATE", "EAT", "ART", "MAT", "MET", "RAT", "SAT", "SET", "RAM", "SAME", "STARE", "RATE", "MATE", "STEM", "TERM", "EAST", "REST", "TEAR", "MARE", "SEAT", "TEAM", "TRAM", "STREAM", "MATS", "SEAM", "MEAT", "MART", "MASTER" };
        string[] compare = new string[35];
        int score = 0;
        public void displayDetails()
        {
            Console.WriteLine("welcome to the game of word PUZZLE\n");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("create words of three or more letters from the word:\tM A S T E R");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nInstructions:\n1. Please enter the words in uppercase only. \n2. Every correct word will add 1 point to your score. \n3. In order to QUIT the game,type  'QUIT'.");
        }
        static void Main(string[] args)
        {
            bool b =true;
            program p =new program();
            p.displayDetails();
            Console.WriteLine("please enter the words.");
            do
            {
                string a;
                a = Console.ReadLine();
                bool c = false;
                for(int i = 0; i < p.compare.Length; i++)
                {
                    if(a == p.compare[i])
                    {
                        c = true;
                    }
                }
                if(c == true)
                {
                    Console.WriteLine("you have already entered: "+a);
                }
                bool d = false;
                foreach (string element in p.result)
                {
                    if(a== element)
                    {
                        if(c == false )
                            {
                                p.score++;
                                for (int i=0; i <p.compare.Length;i++)
                                {
                                    if ((p.compare[i] == "" || p.compare[i] == null))
                                    {
                                        p.compare[i] = a;
            Console.WriteLine("correct");
            break;
                                    }
                                }
                            }
            d=true;
                        }
                    }
            if (a == "QUIT")
            {
                b=false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("your final score is:" + p.score);
            break;
            }
            if(d== false)
            {
            Console.WriteLine("incorrect");
            }
           } while (b) ;
            Console.ReadLine();
            
        }
            }

    }

            
    
          
            
    

            



        
            
        
            
            
            
       
            
           

            

 
                                    
                                    
                                
                               

                            
                            
                

               
            
             



