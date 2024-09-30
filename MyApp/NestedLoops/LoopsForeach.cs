using System.Collections.Generic; // Hinzufügen des Namespaces für List<T>

// Using-Anweisung für den Namespace, der die List<T>-Klasse definiert.
// Um die List<int>-Eigenschaft in der Product-Klasse verwenden zu können,
// solltest du using System.Collections.Generic; am Anfang jeder Datei hinzufügen.

namespace MyApp.NestedLoops
{
    internal class NestedLoopsForeach
    {
        public static void CalculateNestedLoopForeach()
        {
            //Nested Loops
            List<Product> products = new List<Product>();
            products.Add(new Product("Bratpfanne", new List<int> { 3, 1, 2 }));
            products.Add(new Product("Toaster", new List<int> { 1, 1, 2 }));
            products.Add(new Product("Wasserkocher", new List<int> { 8, 2, 4, 1 }));
            products.Add(new Product("Kontaktgrill", new List<int> { 3, 3, 4, 5 }));

            //Durchlaufen aller Produkte
            foreach (Product product in products) // <- outer loop
            {
                Console.WriteLine("Produkt: " + product.Name);

                foreach (int rating in product.Ratings) // <- inner loop
                {
                    Console.WriteLine($"{rating} * für das Produkt {product.Name}");
                }
            }
        }
    }
}
