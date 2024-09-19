using System;

namespace MyApp
{
    internal class NumberCollector
    {
        public static void CollectNumbers()
        {
            int[] numbers = new int[5]; // Array mit 5 Pl�tzen f�r die Zahlen
            int sum = 0; // Variable f�r die Summe der Zahlen

            // Schleife, um den Benutzer 5-mal nach einer Zahl zu fragen
            for (int i = 0; i < numbers.Length; i++)
            // i is less than or equal to 5
            {
                Console.Write($"Bitte geben Sie Zahl {i + 1} ein: ");
                bool validInput = false;

                // Schleife, um sicherzustellen, dass der Benutzer eine g�ltige Zahl eingibt
                while (!validInput)
                {
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out int number))
                    {
                        numbers[i] = number; // Speichere die Zahl im Array
                        validInput = true; // Wenn die Eingabe g�ltig ist, Schleife verlassen
                    }
                    else
                    {
                        Console.WriteLine("Ung�ltige Eingabe. Bitte geben Sie eine g�ltige Zahl ein.");
                    }
                }
            }

            // Berechnung der Summe aller eingegebenen Zahlen
            foreach (int number in numbers)
            {
                sum += number;
            }

            // Ausgabe der Summe
            Console.WriteLine($"Die Summe der eingegebenen Zahlen betr�gt: {sum}");
        }
    }
}
