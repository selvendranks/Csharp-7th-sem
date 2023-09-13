using System;
using System.Threading;

namespace Destructor
{   
    class Sample
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
            Console.WriteLine("Other operations");
            
        }
    }
}
