using System.Collections.Generic; // Hinzufügen des Namespaces für List<T>

// Using-Anweisung für den Namespace, der die List<T>-Klasse definiert.
// Um die List<int>-Eigenschaft in der Product-Klasse verwenden zu können,
// solltest du using System.Collections.Generic; am Anfang jeder Datei hinzufügen.

namespace MyApp.NestedLoops
{
    internal class NestedLoopsFor
    {
        public static void CalculateNestedLoopFor()
        {
            //Nested Loops
            List<Product> products = new List<Product>();
            products.Add(new Product("Bratpfanne", new List<int> { 3, 1, 2 }));
            products.Add(new Product("Toaster", new List<int> { 1, 1, 2 }));
            products.Add(new Product("Wasserkocher", new List<int> { 8, 2, 4, 1 }));
            products.Add(new Product("Kontaktgrill", new List<int> { 3, 3, 4, 5 }));

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("Produkt" + products[i].Name);

                if (products[i].Name == "Toaster")
                {
                    continue;
                }
                // Überspringt die Bewertungen vom Produkt Toaster
                // Bricht die momentane Iteration ab und macht mit den nächsten teil weiter

                // In der inneren Schleife brauchen wir die Referenz auf die äußere Schleife,
                // damit wir wissen auf welchen Produkt Wir uns befnden
                // In der inneren Schleife müssen wir einen anderen Index referenzieren, nach i kommt j 
                for (int j = 0; j < products[i].Ratings.Count; j++)
                {
                    Console.WriteLine($"{products[i].Ratings[j]} * für das Produkt {products[i].Name}");

                    if (products[i].Ratings[j] == 1)
                    {
                        Console.WriteLine("Dieses Produkt is schlecht bewertet.");
                        break;
                        // Wenn Bedingung erfüllt kann ich mit break die Schleife abbrechen
                        // Bricht nur die innere Schleife ab
                    }
                    
                }
            }
        }
    }
}
