using System;
using System.Threading;

namespace ThreadChild
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(WorkerThread);
            t1.Start();
            
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Main thread running");
                Thread.Sleep(1000);
            }
        }

        public static void WorkerThread()
        {
            for(int i = 0;i < 10;i++)
            {
                Console.WriteLine("Running worker thread");
                Thread.Sleep(1000);
            }
        }

    }
}
