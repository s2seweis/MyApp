
namespace MyApp.ObjectOriented
{
    internal class IndexEntry
    {
        public static void CalculateIndex()
        {
            Car myCarOne = new Car("Toyota", "Fortuner", 2004);

            myCarOne.Honk();

            //Console.WriteLine(myCarOne.Brand);
            //Console.WriteLine(myCarOne.Model);
            //Console.WriteLine(myCarOne.Year);

            string info = myCarOne.GetFullInfo();

            Console.WriteLine(info);

            // #######################################################

            float consumption = myCarOne.CalculateFuelConsumption(400, 4.5f);

            Console.WriteLine(consumption);

            Console.WriteLine($"Das Auto verbraucht {consumption} Liter Benzin.");

            // #######################################################

        }
    }
}
