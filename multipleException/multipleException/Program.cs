using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter an Operator (+, -, * or /): ");
            char operation = Console.ReadLine()[0];

            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                throw new InvalidOperationException($"Operation Error: {operation} is not a valid op");
            }

            if (operation == '/' || operation == '%')
            {
                Console.Write("Enter your Second Number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());

                if (secondNumber == 0)
                {
                    throw new DivideByZeroException("Division by zero is not allowed");
                }

                int result = operation == '/' ? firstNumber / secondNumber : firstNumber % secondNumber;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Unsupported operation.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("The number you typed is not valid");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("ERROR!");
            Console.WriteLine($"Operation Error: {ex.Message}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Division Error: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
