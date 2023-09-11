using System;
using System.ComponentModel.DataAnnotations;

public delegate float RectangeArea(float length, float breath);

namespace rectangeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length");
            float length = float.Parse(Console.ReadLine());
            Console.Write("Enter breadth");
            float breadth = float.Parse(Console.ReadLine());

            RectangeArea rectArea = new RectangeArea(rectangleArea);

            Console.WriteLine(rectArea.Invoke(length,breadth));
        }
        
        static float rectangleArea(float width, float height)
        {
            return width * height;
        }
    }

}
