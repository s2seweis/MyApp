using System;

/* The using directive in C# is used to include namespaces in your file. 
 * A namespace is a container for classes, structs, enums, and other types. 
 * By including a namespace with the using directive, 
 * you can use the types defined in that namespace without having to specify the full namespace path each time.
 */

namespace MyApp
{
    internal class BreakpointCalculator
    {
        public static void CalculateBreakPoint()
        {
            while (true)
            {
                Console.WriteLine("Just an example for a Breakpoint! - Press number 1 on your keyboard:");

                // Read the user input
                string input = Console.ReadLine();

                // Validate input: it must be a single digit and equal to '1'
                if (input.Length == 1 && char.IsDigit(input[0])) //accesses the first character of the input string
                {
                    char numberInput = input[0]; // Get the first character of the input

                    // Check if the input is the character '1'
                    if (numberInput == '1')
                    {
                        Console.WriteLine("You pressed the correct key. Exiting.");
                        break; // Exit the loop if the correct input is entered
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter the number 1.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a single digit.");
                }
            }
        }
    }
}
