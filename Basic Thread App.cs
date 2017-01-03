using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleApplication4
{
    class BasicThreadApp
    {
        public static void ChildThreadCall()
        {
            Console.WriteLine("Child thread started");
            int SleepTime =5000;
            Console.WriteLine("Sleeping for {0} Seconds", SleepTime/1000);
         Thread.Sleep(SleepTime);
            Console.WriteLine("Waking Up");
        }
        public static void Main()
        {
            ThreadStart ChildRef = new ThreadStart(ChildThreadCall);
            Console.WriteLine("Main -Creating Child Thread");
            Thread ChildThread = new Thread(ChildRef);
            ChildThread.Start();
            Console.WriteLine("Main - Have requested the start of child thread");
            Console.ReadLine();
        }
    }
}


