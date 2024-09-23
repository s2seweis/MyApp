using System;

namespace MyApp.BankAccount
{
    internal class BankAccountClass
    {
        public string Number { get; private set; }
        public string Owner { get; private set; }
        public float Balance { get; private set; } // You can change this to decimal for better precision

        // Constructor name should match the class name
        public BankAccountClass(string number, string owner, float initialbalance)
        {
            Number = number;
            Owner = owner;
            Balance = initialbalance;
        }

        public void MakeDeposit(float amount)
        {
            Balance += amount;
        }

        public void MakeWithdrawal(float amount) // Corrected method name
        {
            if (amount <= Balance)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Unzureichender Saldo");
            }
        }

        public void PrintBalance()
        {
            Console.WriteLine($"Kontostand von {Owner}: {Balance}");
        }
    }
}
