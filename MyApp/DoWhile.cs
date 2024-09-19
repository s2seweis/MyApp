namespace MyApp
{
    internal class DoWhile
    {
        public static void CalculateDoWhile()
        {
            Random random = new Random();
            int secretNumber = random.Next(1, 11); // Zuf�llige Zahl zwischen 1 und 10
            int userGuess = 0;
            int attempts = 0;
            int maxAttempts = 5; // Begrenzte Anzahl an Versuchen

            Console.WriteLine("Willkommen zum Zahlenratespiel!");
            Console.WriteLine($"Sie haben {maxAttempts} Versuche, um die geheime Zahl zwischen 1 und 10 zu erraten.");

            // do-while Schleife:
            // Die Schleife wird mindestens einmal ausgef�hrt, bevor die Bedingung gepr�ft wird,
            // da die Bedingung erst am Ende steht.
            // Sie eignet sich gut, wenn man mindestens einen Schleifendurchlauf ben�tigt, 
            // wie z.B. um eine Benutzereingabe zu verarbeiten.
            do
            {
                // Benutzer wird nach einer Zahl gefragt
                Console.Write("Geben Sie eine Vermutung ein: ");
                string input = Console.ReadLine();

                // �berpr�fen, ob die Eingabe eine g�ltige Zahl ist
                if (int.TryParse(input, out userGuess))
                {
                    attempts++; // Anzahl der Versuche erh�hen

                    // �berpr�fen, ob die Eingabe im g�ltigen Bereich ist
                    if (userGuess < 1 || userGuess > 10)
                    {
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 10 ein.");
                    }
                    // Hinweis, ob die Eingabe zu hoch ist
                    else if (userGuess > secretNumber)
                    {
                        Console.WriteLine("Zu hoch! Versuchen Sie es nochmal.");
                    }
                    // Hinweis, ob die Eingabe zu niedrig ist
                    else if (userGuess < secretNumber)
                    {
                        Console.WriteLine("Zu niedrig! Versuchen Sie es nochmal.");
                    }

                    // Wenn die maximale Anzahl an Versuchen erreicht ist, endet das Spiel
                    if (attempts >= maxAttempts && userGuess != secretNumber)
                    {
                        Console.WriteLine("Sie haben alle Versuche aufgebraucht! Das Spiel ist vorbei.");
                        break; // Schleife wird abgebrochen, wenn die Versuche aufgebraucht sind
                    }

                    // Ausgabe der verbleibenden Versuche
                    Console.WriteLine($"Verbleibende Versuche: {maxAttempts - attempts}");
                }
                else
                {
                    // Wenn die Eingabe keine Zahl war
                    Console.WriteLine("Ung�ltige Eingabe. Bitte geben Sie eine g�ltige Zahl ein.");
                }

            }
            // while-Bedingung:
            // Die Schleife wiederholt sich so lange, bis der Benutzer die geheime Zahl err�t.
            while (userGuess != secretNumber);

            // Nachricht, wenn die richtige Zahl erraten wurde
            if (userGuess == secretNumber)
            {
                Console.WriteLine($"Gl�ckwunsch! Sie haben die geheime Zahl {secretNumber} nach {attempts} Versuchen erraten.");
            }
        }
    }
}
