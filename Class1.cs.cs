using System;
using CalculatorLibrary;
using CalculatorApp;

namespace CalculatorLibrary
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Creating an instance of SimpleCalculator from the referenced DLL
            SimpleCalculator calculator = new SimpleCalculator();

            // Example usage of addition operation
            calculator.Add(1, 3);
            Console.WriteLine($"Result after addition: {calculator.Result}");

            // Example usage of subtraction operation
            calculator.Subtract(10, 1);
            Console.WriteLine($"Result after subtraction: {calculator.Result}");

            // Example usage of Memory from the referenced DLL
            Memory memory = new Memory();
            memory.AddToMemory(calculator.Result);

            Console.WriteLine("Memory Items: ");
            foreach (var item in memory.GetMemoryItems())
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
