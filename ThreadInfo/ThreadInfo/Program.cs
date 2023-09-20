using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a thread name
        Console.Write("Enter the thread name: ");
        string threadName = Console.ReadLine();

        // Create a new thread and set its name
        Thread customThread = new Thread(ThreadMethod);
        customThread.Name = threadName;

        // Start the custom thread
        customThread.Start();

        // Display thread information
        Console.WriteLine("Current information");
        Console.WriteLine("Thread Name: " + Thread.CurrentThread.Name);
        Console.WriteLine("Thread Status: " + Thread.CurrentThread.IsAlive);

        // Pause to see the output
        Console.ReadLine();
    }

    static void ThreadMethod()
    {
        // This method represents the custom thread's work
        Console.WriteLine("Custom Thread Information");
        Console.WriteLine("Thread Name: " + Thread.CurrentThread.Name);
        Console.WriteLine("Thread Status: " + Thread.CurrentThread.IsAlive);
    }
}
