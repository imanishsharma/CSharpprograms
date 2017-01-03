using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadSample
{
    class BasicThreadApp
    {
        public static void ChildThreadCall()
        {
            try
            {
                Console.WriteLine("Child thread started");
                Console.WriteLine("Child Thread - counting to 10");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    Console.Write("{0}...", i);
                }
                Console.WriteLine("Child Thread finished");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Child thread- Unable the catch the exception");
            }
        }
        public static void Main()
        {
            ThreadStart ChildRef = new ThreadStart(ChildThreadCall);
            Console.WriteLine("Main - Creating Child thread");
            Thread ChildThread = new Thread(ChildRef);
            ChildThread.Start();
            Console.WriteLine("Main - Sleeping for Two Seconds");
            Thread.Sleep(2000);
            Console.WriteLine("\nMain - Aborting Child thread");
            ChildThread.Abort();
            Console.ReadLine();
        }
    }
}