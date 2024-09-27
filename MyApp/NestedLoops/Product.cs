using System.Collections.Generic; // Hinzuf�gen des Namespaces f�r List<T>

// Der Import using System.Collections.Generic;
// ist eine Anweisung in C#, die es dir erm�glicht,
// die Klassen und Datentypen innerhalb des System.Collections.
// Generic-Namespaces zu verwenden, ohne den vollst�ndigen Namen jeder Klasse anzugeben

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
