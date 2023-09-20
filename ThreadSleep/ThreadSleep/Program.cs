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

        }

        public static void WorkerThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(5000);
                Console.WriteLine("Running worker thread");

            }
        }

    }
}
