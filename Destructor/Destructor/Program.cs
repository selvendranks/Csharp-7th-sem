using System;

namespace Destructor
{   
    class Sample
    {
        Sample() {
            Console.WriteLine("Create object");
                }

        ~Sample()
        {
            Console.WriteLine("Destruction");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("other operations");
        }
    }
}
