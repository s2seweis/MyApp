namespace MyApp
{
    internal class ArrayCalculator
    {
        
        public static void CalculateArray()
        {

            //Array: Integer
            // (Mehrere Elemente eines Datentypes in einer Variablen)

            int number = 10;

        //keyword: new(is used to create a new instance of an object or an array)
            int[] numbers = new int[5]
            //{ 100, 200, 300}
            //0,1,2 denote as index
            ;

            numbers[0] = 200; // Das erste Element Element = 100
            numbers[1] = 200;
            numbers[2] = 600;
            numbers[3] = 400;
            numbers[4] = 100;
            //numbers[5] = 400;
            // shows an exception when let the program run, there error sjows:"Index was outside the bounds of the array."


            //Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers.Length);

            Array.Sort(numbers);

            //Array: String

            //string[] names = new string[3];

            //names[0] = "Seastian";
            //names[1] = "Mitzi";
            //names[2] = "Andreas";

            //Console.WriteLine(names.Length);

        }
    }
}