using System;
using System.Threading;

class Program
{
    static int number = 0;
    

    static void PrintEven()
    {
        while (number <= 10)
        {
           
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                    number++;
                }
            
        }
    }

    static void PrintOdd()
    {
        while (number <= 10)
        {
           
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    number++;
                }
            
        }
    }

    static void Main(string[] args)
    {
        Thread t1 = new Thread(PrintEven);
        Thread t2 = new Thread(PrintOdd);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();

        Console.ReadKey();
    }
}
