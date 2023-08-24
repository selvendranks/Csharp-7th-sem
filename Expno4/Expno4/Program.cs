using System;

namespace Expno4
{
    class Student
    {
        public int RollNo;
        public string StudName;
    }

    class Test : Student
    {
        public int Marks1;
        public int Marks2;
    }

    class Result : Test
    {
        public int Total => Marks1 + Marks2;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Result result = new Result();

            Console.Write("Enter Roll No: ");
            result.RollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Student Name: ");
            result.StudName = Console.ReadLine();

            Console.Write("Enter Marks in Test 1: ");
            result.Marks1 = int.Parse(Console.ReadLine());

            Console.Write("Enter Marks in Test 2: ");
            result.Marks2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nStudent Information:");
            Console.WriteLine($"Roll No: {result.RollNo}");
            Console.WriteLine($"Student Name: {result.StudName}");
            Console.WriteLine($"Marks in Test 1: {result.Marks1}");
            Console.WriteLine($"Marks in Test 2: {result.Marks2}");
            Console.WriteLine($"Total Marks: {result.Total}");
        }
    }
}
