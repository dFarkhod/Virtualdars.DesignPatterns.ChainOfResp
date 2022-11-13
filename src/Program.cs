using System;
namespace Virtualdars.DesignPatterns.ChainOfResp
{
    class Program
    {
        static void Main(string[] args)
        {
            AtmTransaction();
        }

        private static void AtmTransaction()
        {
            ATM atm = new();
            while (true)
            {
                Console.WriteLine("\nYechib olmoqchi bo'lganingiz pul miqdorini kiriting:");
                string amountStr = Console.ReadLine();
                int amount = 0;
                if (string.IsNullOrWhiteSpace(amountStr) || !int.TryParse(amountStr, out amount))
                {
                    StopTransaction("Pul miqdori son bo'lishi lozim.");
                    continue;
                }
                if (amount <= 0)
                {
                    StopTransaction("Pul miqdori 0 dan katta bo'lishi lozim.");
                    continue;
                }
                if (amount % 5 != 0)
                {
                    StopTransaction("Pul miqdori 5ga bo'linadigan son bo'lishi lozim.");
                    continue;
                }

                Console.WriteLine($"{amount}$ miqdorda pul yechib olish boshlandi...");
                atm.Withdraw(amount);
                Console.WriteLine("Tranzaktsiya muvaffaqqiyatli yakunlandi.");
            }
        }

        private static void StopTransaction(string errorMessage)
        {
            Console.WriteLine(errorMessage);
            Console.WriteLine("Tranzaktsiya xato bilan yakunlandi.");
        }
    }
}