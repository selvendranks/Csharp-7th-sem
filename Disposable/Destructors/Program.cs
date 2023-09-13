using System;
using ClassLibrary1;

namespace Destructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Sample s = new Sample())
            {
                s.database();
                Console.WriteLine("All done");
            }
            Console.WriteLine("Other operations");
            Console.ReadKey();
        }
    }
}
