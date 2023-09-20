using System;
using System.Threading;

namespace SimpleThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(sampleThread);
            t1.Start();
        }

        public static void sampleThread()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Simple Thread");
            }
        }
    }
}
