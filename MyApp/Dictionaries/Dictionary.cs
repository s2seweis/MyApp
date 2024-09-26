
namespace MyApp.Dictionaries
{
    internal class Dictionary
    {
        public static void CalculateIndexDictionary()
        {
            // Englisch | Deutsch
            // Cart | Warenkorb
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic.Add("Cart", "Warenkorb");
            dic.Remove("Cart");

            // Produkt | Preis
            // Milch | 1.49f
            Dictionary<string, float> products = new Dictionary<string, float>();
            products.Add("Milch", 1.49f);
            products.Remove("Milch");

            // ID | Person 
            // 50 | Objekt "Jannick"
            Dictionary<int, Person> people = new Dictionary<int, Person>();
            people.Add(50, new Person());
            people.Remove(50);
        }
    }

    public class Person
    {
        // Properties
    }
}
