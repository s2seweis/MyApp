
namespace MyApp.Dictionaries
{
    internal class DictionaryMethods
    {
        public static void CalculateDictionaryMethods()
        {
            // Produkt | Preis
            // Milch | 1.49f
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Milch", 1.49f);
            products.Add("Brot", 1.99f);
            products.Add("�ppfel", 3.19f);

            // Schl�sselabfragen in einem Dictionary sind in der Regel O(1), d.h. sie erfolgen in konstanter Zeit und sind sehr schnell.
            // Das Abrufen eines Wertes �ber den Schl�ssel ist ebenfalls O(1). Wenn jedoch komplexe Operationen auf den Werten durchgef�hrt werden, kann dies die Leistung beeintr�chtigen.

            //if (products.ContainsKey("Milch"))
            //if (products.Containsvalue("1.49f"))
            //{

            //}

            //float price;

            //if (products.TryGetValue("Brot", out float price))
            //{
            //    // Wird wahr
            //} else
            //{
            //    //key nicht gefunde
            //};

            

        }
    }
}
