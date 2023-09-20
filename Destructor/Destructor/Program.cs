using System;

namespace Destructor
{   
    public class Sample
    {
        public Sample() {
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
            Sample s = new Sample();
            Console.WriteLine("other operations");
        }
    }
}
