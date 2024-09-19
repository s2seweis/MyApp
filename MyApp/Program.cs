namespace MyApp
    //both in the same namespace: MyApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            FloatCalculator.CalculateFloats();
            StringCalculator.CalculateStrings();
            VariableCalculator.CalculateVariables();
            BoolCalculator.CalculateBool();
            CharCalculator.CalculateChar();

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


            Console.ReadKey(); // Wartet auf eine Taste, damit die Konsole offen bleibt

        }
    }
}
