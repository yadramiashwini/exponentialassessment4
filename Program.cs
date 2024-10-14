namespace exponentialassessment4
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            // Prompt the user to enter a number
            Console.Write("Enter the number: ");
            string input = Console.ReadLine();

            // Parse the input to a double
            if (double.TryParse(input, out double number))
            {
                // Display the number in exponential format
                string exponentialFormat = number.ToString("E6");
                Console.WriteLine($"Exponential is {exponentialFormat}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }
    }
}