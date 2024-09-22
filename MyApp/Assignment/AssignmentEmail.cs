namespace MyApp.Assignment
{
    internal class AssignmentEmail
    {
        public static void CalculateEmail()
        {
            // Erstelle ein Array mit 5 E-Mail-Adressen
            string[] emailAdressen = new string[]
            {
                "max.mustermann@example.com",
                "anna.smith@example.com",
                "john.doe@example.com",
                "jane.doe@example.com",
                "info@example.com"
            };

            // Verwende eine foreach-Schleife, um jede E-Mail-Adresse auszugeben
            foreach (string email in emailAdressen)
            {
                Console.WriteLine(email);
            }
        }
    }
}
