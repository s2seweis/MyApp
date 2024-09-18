namespace MyApp
    //both in the same namespace: MyApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //FloatCalculator.CalculateFloats();
            //StringComponent.CalculateStrings();
            //VariableComponent.CalculateVariables();

            string username = "Sebastian Weissenborn";

            //username = "Peter"; // Uncomment this line to change the username

            // create a variable

            Console.WriteLine(username);

            // Last assigned value is the current value

            // Declare Variables:
            int age = 36;
            age = 30;

            Console.WriteLine(age);

            // Last assigned value is the current value

            // Shortcuts:
            // end of the line semicolon, for command is over
            // beginning of the line: shift + 7
            // end of the line: shift + 1
            // move line up and down: alt + up/down

            // Calculate Numbers:
            int a = 100;
            int b = 200;

            int result = a + b;

            Console.WriteLine(result);

            // Shortcuts:
            // Ctrl + K, then Ctrl + C (this will comment out the selected block)
            // Press Ctrl + K, then Ctrl + U (this will uncomment the selected block)
            // mark words: alt + shift + . (repeatedly)

            // Good to know:

            // Console.ReadLine(); 
            // Wartet auf eine Eingabe, damit die Konsole offen bleibt
            // Zoom in/out: strg + mouse rad

            Console.ReadKey(); // Wartet auf eine Taste, damit die Konsole offen bleibt
        }
    }
}
