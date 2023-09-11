using System;

namespace indexOutofRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5 };

            try
            {
                Console.WriteLine(arr[6]);
            }
            catch(Exception ex) 
            {
                Console.WriteLine($"{ex.Message}\n");
            }
        }
    }
}
