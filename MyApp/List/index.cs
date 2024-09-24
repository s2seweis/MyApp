using System;
using System.Collections.Generic; // F�ge diesen Namespace hinzu

namespace MyApp.List
{
    internal class IndexEntryThree
    {
        public static void CalculateIndexThree()
        {
            // Liste korrekt initialisieren und mit Werten f�llen
            List<string> names = new List<string>
            {
                "Jannick", "Marc", "Julia"
            };

            //Element Hinzuf�gen
            names.Add("Maria");

            //Mark wird durch Peter ersetzt
            names[1] = "Peter";

            // Das zweite Element der Liste ausgeben

            Console.WriteLine(names[3]); // Ausgabe: Marc

            foreach (string name in names)
            {

                Console.WriteLine(name);
            }
        }
    }

}
