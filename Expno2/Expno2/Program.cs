using System;

namespace Expno2
{
    using System;

    struct Student
    {
        public int StudentId;
        public string StudentName;
        public string CourseName;
        public DateTime DateOfBirth;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentCount = 0;
            Student[] student = new Student[10];
            while (true)
            {
               
                Console.WriteLine("Enter Student Information:");
                Console.Write("Student Id: ");
                int studentId = int.Parse(Console.ReadLine());

                Console.Write("Student Name: ");
                string studentName = Console.ReadLine();

                Console.Write("Course Name: ");
                string courseName = Console.ReadLine();

                Console.Write("Date of Birth (yyyy-MM-dd): ");
                DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(), "yyyy-MM-dd", null);

                student[studentCount] = new Student
                {
                    StudentId = studentId,
                    StudentName = studentName,
                    CourseName = courseName,
                    DateOfBirth = dateOfBirth
                };

                studentCount++;

                Console.Write("Do you want to enter another student? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
            Console.WriteLine("\nStudent Information:\n");
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine($"Student Id: {student[i].StudentId}");
                Console.WriteLine($"Student Name: {student[i].StudentName}");
                Console.WriteLine($"Course Name: {student[i].CourseName}");
                Console.WriteLine($"Date of Birth: {student[i].DateOfBirth.ToString("yyyy-MM-dd")}");
                Console.WriteLine();
            }

        }
    }
}
