using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadExample
{
    class FileAccess
    {
        public void WriteData(string Data)
        {
            lock (this)
            {
                Console.WriteLine("FileAccess.WriteData - Started");
                Console.WriteLine("FileAccess.WriteData - Working");
                for (int Cnt = 0; Cnt < 100; Cnt++)
                {
                    Console.Write(Data);
                }
                Console.WriteLine("FileAccess.WriteData - Ended");
            }
        }
    }
    class ThreadLockClass
    {
        public static FileAccess Fd = new FileAccess();
        public static void ChildThread1()
        {
            Console.WriteLine("Child thread #1 - Started");
            Console.WriteLine("Child thread #1 -Calling FileAccess.WriteData");
            Fd.WriteData("T1");
            Console.WriteLine("Child thread #1 - Returned from Output");
        }
        public static void ChildThread2()
        {
            Console.WriteLine("Child thread #2 - Started");
            Console.WriteLine("Child thread #2 - Calling FileAccess.WriteData");
            Fd.WriteData("T2");
            Console.WriteLine("Child thread #2 - Returned from Output");
        }
        public static void Main()
        {
            ThreadStart Child1 = new ThreadStart(ChildThread1);
            ThreadStart Child2 = new ThreadStart(ChildThread2);
            Console.WriteLine("Main - Creating Child threads");
            Thread Thread1 = new Thread(Child1);
            Thread Thread2 = new Thread(Child2);
            Thread1.Start();
            Thread2.Start();
            Console.ReadLine();
        }
    }
}
