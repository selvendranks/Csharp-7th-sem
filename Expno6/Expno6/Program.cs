using System;

namespace Expno6
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 != 0)
                {
                    throw new Exception("Number is not an even number.");
                }

                Console.WriteLine("Entered number is even.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
         
        }
    }

}
