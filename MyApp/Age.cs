using System;

namespace MyApp
{
    internal class AgeCalculator
    {
        public static void CalculateAge()
        {
            // Prompt the user to enter their age
            Console.WriteLine("Bitte trage dein Alter ein:");

            // Read the user's age from the console
            string ageInput = Console.ReadLine();
            // only possible to enter strings because of the return value => because of this we need to parse it

            // Validate the input and parse it to an integer
            if (int.TryParse(ageInput, out int age))
            {
                // Get the current year
                int currentYear = DateTime.Now.Year;

                // Calculate the birth year
                int birthYear = currentYear - age;

                // Display the calculated age and birth year
                Console.WriteLine("Dein Alter ist also: " + age);
                //Breakpoint is placed, the program will stop here, program runs from up to down, we can inspect during the debug mode all variables and their values => remove the breakpoint again by click on it
                Console.WriteLine("Du bist geboren im Jahr " + birthYear + ".");
            }
            else
            {
                // Inform the user if the input was invalid
                Console.WriteLine("Bitte gib ein gültiges Alter ein.");
            }

            // Keep the console window open until the user presses Enter
            Console.WriteLine("Drücke eine beliebige Taste zum Beenden...");
            Console.ReadLine();
        }
    }
}
