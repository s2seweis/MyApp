namespace MyApp
{
    internal class WhileGamePro
    {
        public static void WhileGameAdvaned()
        {
            int secretNumber = 3;
            int userGuess = 0;
            int maxAttempts = 5;
            int attempts = 0;
            bool gameWon = false;

            Console.WriteLine("Willkommen zum Zahlenratespiel!");

            while (attempts < maxAttempts && !gameWon)
            {
                Console.WriteLine("Geben Sie Ihre Vermutung ein:");
                string input = Console.ReadLine();

                // Fehlerbehandlung für ungültige Eingaben
                if (int.TryParse(input, out userGuess))
                {
                    attempts++; // Zähle die Versuche

                    if (userGuess == secretNumber)
                    {
                        gameWon = true;
                        Console.WriteLine("Das war richtig!");
                    }
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Ihre Vermutung ist zu hoch.");
                    }
                    else
                    {
                        Console.WriteLine("Ihre Vermutung ist zu niedrig.");
                    }

                    Console.WriteLine($"Sie haben noch {maxAttempts - attempts} Versuche übrig.");
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Zahl ein.");
                }
            }

            // Ergebnis basierend auf dem Spielausgang
            if (!gameWon)
            {
                Console.WriteLine("Sie haben leider verloren. Die richtige Zahl war: " + secretNumber);
            }
            else
            {
                Console.WriteLine($"Sie haben das Spiel in {attempts} Versuchen gewonnen!");
            }
        }
    }
}
