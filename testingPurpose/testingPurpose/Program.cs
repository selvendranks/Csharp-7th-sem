using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of names
        List<string> names = new List<string>
        {
            "Alice",
            "Charlie",
            "Bob",
            "David",
            "Eve"
        };

        // Sort the list in alphabetical order
        names.Sort();

        // Display the sorted names
        Console.WriteLine("Sorted Names:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }
    }
}
