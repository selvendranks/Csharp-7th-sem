using System;

public delegate int feetToInch(int feet);

namespace feetToinch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int feet = Convert.ToInt32(Console.ReadLine());

            feetToInch fettoInch = new feetToInch(FeetToInch);
            Console.WriteLine(fettoInch.Invoke(feet));
        }

        static int FeetToInch(int feet)
        {
            return feet * 12;
        }
    }
}
