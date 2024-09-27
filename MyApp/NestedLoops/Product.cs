using System.Collections.Generic; // Hinzufügen des Namespaces für List<T>

// Der Import using System.Collections.Generic;
// ist eine Anweisung in C#, die es dir ermöglicht,
// die Klassen und Datentypen innerhalb des System.Collections.
// Generic-Namespaces zu verwenden, ohne den vollständigen Namen jeder Klasse anzugeben

namespace MyApp.NestedLoops
{
    internal class Product
    {
        public string Name { get; private set; }

        public List<int> Ratings { get; private set; }


        public Product(string name, List<int> ratings)
        {
            Name = name;
            Ratings = ratings;
        }
    }
}
