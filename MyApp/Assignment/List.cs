using System;
using System.Collections.Generic;

namespace MyApp.Assignment
{
    public class List
    {
        // 1. Erstelle hier ein Feld (leere Liste vom typ int)
        // Wichtig: Initialisiere das Feld mit einer leeren Liste (Tipp: new)
        private List<int> numbers = new List<int>();

        // 2. Erweitere diese Methode, damit sie der Liste eine variable Zahl hinzuf�gt
        // Tipp: Parameter einbauen
        public void AddNumber(int number)
        {
            numbers.Add(number); // Zahl zur Liste hinzuf�gen
        }

        // 3. Passe diese Methode an, damit sie den Durchschnitt der Zahlen in der Liste
        // berechnet und zur�ckgibt
        public float CalculateAverage()
        {
            if (numbers.Count == 0) // Wenn keine Zahlen in der Liste sind
                return 0;

            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number; // Summe der Zahlen berechnen
            }

            // Durchschnitt berechnen und zur�ckgeben
            return (float)sum / numbers.Count;
        }
    }
}