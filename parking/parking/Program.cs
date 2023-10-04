using System;
using System.Threading;

class ParkingGarage
{
    private int vehicles;
    private double revenue;
    private object lockObj = new object();

    public ParkingGarage()
    {
        vehicles = 0;
        revenue = 0.0;
    }

    public void VehicleEnter()
    {
       
        
            vehicles++;
            Console.WriteLine("Vehicle entered. Total vehicles: " + vehicles);
        
    }

    public void VehicleExit(double fee)
    {
       
            if (vehicles > 0)
            {
                vehicles--;
                revenue += fee;
                Console.WriteLine("Vehicle exited. Total vehicles: " + vehicles + ". Total revenue: " + revenue);
            }
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        ParkingGarage garage = new ParkingGarage();

        for (int i = 0; i < 10; i++)
        {
            Thread t1 = new Thread(garage.VehicleEnter);
            Thread t2 = new Thread(() => garage.VehicleExit(10.0));

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }
        Console.ReadKey();
    }
}
