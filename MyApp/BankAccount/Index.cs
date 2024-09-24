using System;

namespace MyApp.BankAccount // Changed namespace to avoid conflict with class name
{
    internal class IndexEntryTwo
    {
        public static void CalculateIndexTwo()
        {


            Console.WriteLine("Bitte geben Sie ihren Name ein:");
            string name = Console.ReadLine();


            Console.WriteLine("Bitte geben Sie Ihre Kontennummer ein:");
            string number = Console.ReadLine();


            Console.WriteLine("Bitte geben Sie ihren Kontostand ein:");
            float initialBalance = float.Parse(Console.ReadLine());

            // Correct constructor usage, matching the new class name
            BankAccountClass account = new BankAccountClass(
                //"1234567890",
                number,
                //"Sebastian Weissenborn",
                name,
                //100f // float (or change to decimal if you prefer)
                initialBalance
            ); ;
            
            while (true)
            {
                Console.WriteLine("Bitte wählen Sie eine Aktion aus:");
                Console.WriteLine("1. Kontostand anzeigen");
                Console.WriteLine("2. Einzahlung machen");
                Console.WriteLine("3. Auszahlung machen");
                Console.WriteLine("4. Beenden");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    account.PrintBalance();
                }
                else if (input == "2")
                {
                    // Fixed missing parenthesis
                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie einzahlen möchten:");
                    float depositAmount = float.Parse(Console.ReadLine());
                    account.MakeDeposit(depositAmount);
                }
                else if (input == "3")
                {
                    // Fixed missing parenthesis
                    Console.WriteLine("Bitte geben Sie den Betrag ein, den Sie abheben möchten:");
                    float withdrawalAmount = float.Parse(Console.ReadLine());
                    account.MakeWithdrawal(withdrawalAmount); // Corrected method name
                }
                else if (input == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Ungültige Auswahl. Bitte versuchen Sie es erneut.");
                }
            }
        }
    }
}
