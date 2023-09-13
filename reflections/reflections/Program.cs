using System;
using System.Reflection;

namespace AssemblyInfoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string assemblyPath = "Customer.dll"; // Replace with the actual path to your Customer assembly

            // Load the assembly
            Assembly customerAssembly = Assembly.LoadFrom(assemblyPath);

            // Display Assembly Information
            Console.WriteLine("Assembly Information");
            Console.WriteLine($"Name: {customerAssembly.FullName}");
            Console.WriteLine($"Version: {customerAssembly.GetName().Version}");
            Console.WriteLine($"Location: {assemblyPath}");
            Console.WriteLine();

            // Display Module Information
            Console.WriteLine("Module Information");
            foreach (var module in customerAssembly.GetModules())
            {
                Console.WriteLine($"Name: {module.Name}");
                Console.WriteLine($"Fully Qualified Name: {module.FullyQualifiedName}");
            }
            Console.WriteLine();

            // Display Classes Information
            Console.WriteLine("Classes Information");
            foreach (var type in customerAssembly.GetTypes())
            {
                Console.WriteLine($"Class Name: {type.FullName}");

                // Constructors Information
                Console.WriteLine("Constructor Names with Parameters:");
                foreach (var constructor in type.GetConstructors())
                {
                    Console.Write($"{constructor.Name}(");
                    ParameterInfo[] parameters = constructor.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                        if (i < parameters.Length - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }

                // Properties Information
                Console.WriteLine("Properties Information:");
                foreach (var property in type.GetProperties())
                {
                    Console.WriteLine($"Property Name: {property.Name}, Type: {property.PropertyType.Name}");
                }

                // Methods Information
                Console.WriteLine("Method Names with Parameters:");
                foreach (var method in type.GetMethods())
                {
                    Console.Write($"{method.Name}(");
                    ParameterInfo[] parameters = method.GetParameters();
                    for (int i = 0; i < parameters.Length; i++)
                    {
                        Console.Write($"{parameters[i].ParameterType.Name} {parameters[i].Name}");
                        if (i < parameters.Length - 1)
                            Console.Write(", ");
                    }
                    Console.WriteLine(")");
                }

                Console.WriteLine();
            }

            Console.ReadLine(); // Keep the console window open
        }
    }
}
