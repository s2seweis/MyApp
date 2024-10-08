
namespace MyApp.Exceptions
{
    internal class ExceptionsHandlingOne
    {
        int a = 20;
        int b = 2;

        public static void CalculateExceptionsOne()
        {

            try
            {
                // Calc wirft einen Fehler, da Fehler im Catch Blog nicht behandelt wird,
                // steht hier erstmal nichts mehr von der Exception
                // kritischer Code wird ausgeführt, wenn Fehler geworfen wird Catch Block ausgeführt 
            var result = Calc(10, 0);
            Console.WriteLine(result); 
            } catch (Exception e)
            {
                Console.WriteLine("Something went wrong. Exception:" + e);
            } finally
            {
                Console.WriteLine("Done");
            }


            Console.WriteLine("Hello World!");

            // Das Ziel ist es ein Absturzsicheren Code zu schreiben
            // Beispiel Datenbankabfrage, wenn keine Datenbank vorhanden soll der gesamte Code nicht gleich unbrauchbar sein

            // !! Exkurs:
            // bei jedem Lauf oder jeder wichtigen Aktion des Programms ein Logfile zu erstellen oder zu aktualisieren.
            // Ein Logfile ist eine Datei, in der Informationen über den Programmablauf, Fehler,
            // Warnungen oder allgemeine Informationen festgehalten werden. 


        }

        static int Calc(int a, int b)
        {
            // Unhandled exception => Attempted to divide by zero.
            return a / b;
        }

    }
}
