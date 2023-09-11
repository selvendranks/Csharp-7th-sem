using System;
delegate void addNumber(int x);
namespace AnonymousMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            addNumber nc = (int x) =>
            {
                Console.WriteLine(x);
            };

            nc(10);

        }
    }
}
