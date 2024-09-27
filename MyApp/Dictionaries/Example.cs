
namespace MyApp.Dictionaries
{
    internal class ExampleDictionary
    {
        public static void CalculateExampleDictionary()
        {

            int[] numbers = new int[10]
            {
                40,60,30,20,40,30,80,90,80,30
            };

            Dictionary<int, int> numbersCount = new Dictionary<int, int>();

            foreach (int number in numbers)
            {
                {
                    if (numbersCount.ContainsKey(number))
                    {
                        // Number kommt vor (key existiert)
                        numbersCount[number] += 1;
                    }
                    else
                    {
                        numbersCount.Add(number, 1);
                    }
                }

            }
        }
    }
}
