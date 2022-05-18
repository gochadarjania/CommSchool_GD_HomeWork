using System;
using Week_10.Task_2;

namespace Week_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankSeed();
            MicroFinanceSeed();
        }

        public static void BankSeed()
        {
            var bank = new Bank() { Months = 5, LoanAmount = 500 };
            if (bank.CheckUserHistory())
            {
                Console.WriteLine(bank.CalculateLoanPercent(bank.Months, bank.LoanAmount));

            }
        }

        public static void MicroFinanceSeed()
        {
            var microFinance = new MicroFinance() { Months = 5, LoanAmount = 500 };
            if (microFinance.CheckUserHistory())
            {
                Console.WriteLine(microFinance.CalculateLoanPercent(microFinance.Months, microFinance.LoanAmount));

            }

        }
    }
}
