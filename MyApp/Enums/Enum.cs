
namespace MyApp
{
    internal class Enum
    {
        public static void CalculateEnum()
        {
            // Switches are, in certain cases, a simpler and cleaner alternative to if-else statements in C#,
            // especially when checking multiple conditions for a single variable.


            Console.WriteLine("Bitte geben Sie einen Wochentag ein (1-7):");

            int day = int.Parse(Console.ReadLine());

            // can be used for check simple values
            switch (day)
            {
                case 1:
                    Console.WriteLine("Montag");
                    break;
                
                case 2:
                    Console.WriteLine("Dienstag");
                    break;

                case 3:
                    Console.WriteLine("Mittwoch");
                    break;

                case 4:
                    Console.WriteLine("Donnerstag");
                    break;

                case 5:
                    Console.WriteLine("Freitag");
                    break;

                case 6:
                    Console.WriteLine("Samstag");
                    break;

                case 7:
                    Console.WriteLine("Sonntag");
                    break;

                default:

                    Console.WriteLine("Ungültige Einnahme");
                    break;
            }

        }
    }
}
