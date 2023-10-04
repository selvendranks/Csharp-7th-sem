using System;
using System.Threading;

class TollBooth
{
    private int numberOfPeople;
    private decimal totalAmountCollected;
    private object lockObject = new object(); // Lock object for thread safety

    public TollBooth()
    {
        numberOfPeople = 0;
        totalAmountCollected = 0;
    }

    // Increment the number of people and amount collected when someone passes by
    public void PassBy(int peopleCount, decimal amount)
    {
        lock (lockObject)
        {
            if (peopleCount < 0)
            {
                throw new ArgumentException("People count cannot be negative.");
            }

            numberOfPeople += peopleCount;
            totalAmountCollected += amount;
        }
    }

    // Display the results
    public void DisplayResults()
    {
        Console.WriteLine("Toll Booth Results:");
        Console.WriteLine($"Number of people visited: {numberOfPeople}");
        Console.WriteLine($"Total amount collected: Rs. {totalAmountCollected}");
    }

    ~TollBooth()
    {
        // Destructor (cleanup, if needed)
    }
}

class Program
{
    static void Main(string[] args)
    {
        TollBooth booth1 = new TollBooth();
        TollBooth booth2 = new TollBooth();

        // Create and start threads to simulate people passing by the booths
        Thread thread1 = new Thread(() =>
        {
            for (int i = 1; i <= 100; i++)
            {
                booth1.PassBy(1, 30); // 1 person paying Rs. 30
                Thread.Sleep(10); // Simulate a delay
            }
        });

        Thread thread2 = new Thread(() =>
        {
            for (int i = 1; i <= 80; i++)
            {
                booth2.PassBy(1, 30); // 1 person paying Rs. 30
                Thread.Sleep(15); // Simulate a delay
            }
        });

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();

        booth1.DisplayResults();
        booth2.DisplayResults();
    }
}
