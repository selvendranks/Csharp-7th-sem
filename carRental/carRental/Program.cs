using System;

class Car
{
    private string make;
    private string model;
    private decimal rentalPrice;
    private bool rented;

    public Car(string make, string model, decimal rentalPrice)
    {
        this.make = make;
        this.model = model;
        this.rentalPrice = rentalPrice;
        this.rented = false;
    }

    public bool Rent()
    {
        if (!rented)
        {
            rented = true;
            Console.WriteLine($"You have rented the {make} {model}.");
            return true;
        }
        else
        {
            Console.WriteLine($"Error: The {make} {model} is already rented.");
            return false;
        }
    }

    public bool Return()
    {
        if (rented)
        {
            rented = false;
            Console.WriteLine($"You have returned the {make} {model}.");
            return true;
        }
        else
        {
            Console.WriteLine($"Error: The {make} {model} is not currently rented.");
            return false;
        }
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Car: {make} {model}");
        Console.WriteLine($"Rental Price: ${rentalPrice}");
        Console.WriteLine($"Availability: {(rented ? "Not Available" : "Available")}");
    }
}

class Program
{
    static void Main()
    {
        // Create some car objects
        Car car1 = new Car("Toyota", "Camry", 50.0m);
       

        // Rent and return cars
        car1.Rent();
        car1.PrintInfo();
        
        car1.Rent();
        car1.Return();
       

        Console.ReadLine(); // Keep the console window open
    }
}
