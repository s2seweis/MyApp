using System;

namespace MyApp
{
    internal class NumberCollector
    {
        public static void CollectNumbers()
        {
            int[] numbers = new int[5]; // Array mit 5 Plätzen für die Zahlen
            int sum = 0; // Variable für die Summe der Zahlen

            // Schleife, um den Benutzer 5-mal nach einer Zahl zu fragen
            for (int i = 0; i < numbers.Length; i++)
            // i is less than or equal to 5
            {
                Console.Write($"Bitte geben Sie Zahl {i + 1} ein: ");
                bool validInput = false;

                // Schleife, um sicherzustellen, dass der Benutzer eine gültige Zahl eingibt
                while (!validInput)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int number))
                    {
                        numbers[i] = number; // Speichere die Zahl im Array
                        validInput = true; // Wenn die Eingabe gültig ist, Schleife verlassen
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                    }
                }
            }

            // Berechnung der Summe aller eingegebenen Zahlen
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Ausgabe der Summe
            Console.WriteLine($"Die Summe der eingegebenen Zahlen beträgt: {sum}");
        }
    }
}
