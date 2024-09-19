namespace MyApp
    // Namespace-Scope
{
    internal class Program
    // Class-Scope
    {

        //Variable in class level/scope/ scope
        static string username = "Hans";
  
        //private static void Main(string[] args)
        //// Main method from which the program starts, scope limited to the class in which it was defined
        //{
        //    //username = "Peter";
        //    //Console.WriteLine(username);

        //    //Methods:
        //    //FloatCalculator.CalculateFloats();
        //    //StringCalculator.CalculateStrings();
        //    //VariableCalculator.CalculateVariables();
        //    //BoolCalculator.CalculateBool();
        //    //CharCalculator.CalculateChar();

        //    Console.ReadKey(); // Wartet auf eine Taste, damit die Konsole offen bleibt

        //}

        static void Main(string[] args)
        {

            Console.WriteLine("Bitte trage deinen namen ein:");
            //e.g we call the Console Class and select one method

            string username = "Sebastian";
            string name = Console.ReadLine();
            // return value string, when you slide over the method you see the return value string "strin?Console.readLine()"

            Console.WriteLine("Dein Name ist also: " + name  );
        }

    }
}

// Shortcuts:
// end of the line semicolon, for command is over
// beginning of the line: shift + 7
// end of the line: shift + 1
// move line up and down: alt + up/down
// copy line strg + e after strg + v
// delete line strg + x
// Ctrl + K, then Ctrl + C (this will comment out the selected block)
// Press Ctrl + K, then Ctrl + U (this will uncomment the selected block)
// mark words: alt + shift + . (repeatedly)

// Good to know:
// Console.ReadLine(); 
// Wartet auf eine Eingabe, damit die Konsole offen bleibt
// Zoom in/out: strg + mouse rad

//Longer Comments:
/* 
 * 
 */