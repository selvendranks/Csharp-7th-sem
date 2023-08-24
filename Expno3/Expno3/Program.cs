using System;

namespace Expno3
{   

    class Staff
    {
        public String name;
        public String post;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Staff[] staff = new Staff[5];

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter Staff Information:");
                Console.Write("Staff name: ");
                String staffName = Console.ReadLine();

                Console.Write("Staff Post: ");
                String staffPost = Console.ReadLine();

                staff[i] = new Staff
                {
                    name = staffName,
                    post = staffPost
                };
               
            }
            for (int j = 0; j < 5; j++)
            {
                if (staff[j].post == "HOD")
                {
                    Console.WriteLine($"name: {staff[j].name}");
                    Console.WriteLine($"post: {staff[j].post}");
                }
             }
        }
    }
}
