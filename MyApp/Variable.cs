namespace MyApp
{
    internal class VariableCalculator
    {
        public static void CalculateVariables()
        {
            string username = "Sebastian Weissenborn";

            Console.WriteLine(username);

            int age = 36;
            age = 30;

            Console.WriteLine(age);

            int a = 100;
            int b = 200;

            int result = a + b;

            Console.WriteLine(result);

            // Last assigned value is the current value

        }
    }
}
