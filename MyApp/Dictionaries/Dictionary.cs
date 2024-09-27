
namespace MyApp.Dictionaries
{
    internal class Dictionary
    {
        public static void CalculateDictionary()
        {
            // Produkt | Preis
            // Milch | 1.49f
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Milch", 1.49f);
            products.Add("Brot", 1.99f);
            products.Add("Äppfel", 3.19f);

            // set a new price
            //products["Milch"] = 4.99f;

            //Console.WriteLine(products["Milch"]);

            //every possible data type  
            // iterate over products
            foreach (KeyValuePair<string, float> product in products)
            {
                Console.WriteLine(product.Key + " " + product.Value);
            }

        }
    }
}
