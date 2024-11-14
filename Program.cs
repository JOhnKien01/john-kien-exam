using System;

namespace Kien
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // Infinite loop 
            {
                Console.Write("Enter a NUMBER (or type 'exit' to quit): ");
                string input = Console.ReadLine();

                // Allow the user to exit the loop
                if (input.ToLower() == "exit")
                {
                    break; // Exit the loop
                }

                // Try to parse the input to an integer
                if (int.TryParse(input, out int n))
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        int multiple = n * i; // Correct calculation of multiples

                        // Check if the multiple is even or odd
                        if (multiple % 2 == 0)
                        {
                            Console.WriteLine($"{multiple} : EVEN");
                        }
                        else
                        {
                            Console.WriteLine($"{multiple} : ODD");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }
        }
    }
}

