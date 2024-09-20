namespace MyApp
{
    internal class AssignmentIf
    {
        public static void CalculateAssignmentIf()
        {
            // Aufgabe: Schreibe ein Programm, das dich auffordert,
            // einen Benutzernamen und ein Passwort einzugeben
            // und dann überprüft, ob sowohl der Benutzername
            // als auch das Passwort korrekt sind.

            string correctUsername = "Benutzer";
            string correctPassword = "Password";

            Console.WriteLine("Bitte gib einen Benutzernamen ein:");
            // Fixed capitalization error (Readline to ReadLine)
            string username = Console.ReadLine();

            Console.WriteLine("Bitte gib dein Passwort ein:");
            // Removed unnecessary '4' and fixed capitalization error (Readline to ReadLine)
            string password = Console.ReadLine();

            if (username == correctUsername && password == correctPassword)
            {
                Console.WriteLine("Anmeldung erfolgreich");
            }
            else
            {
                Console.WriteLine("Falscher Benutzername oder Passwort.");
            }
        }
    }
}
