using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10.Task_2
{
    internal class Bank : BaseBank, IFinanceOperations
    {
        public int CalculateLoanPercent(int month, int loanAmount)
        {
            var loanPercent = 5;
            return loanAmount * loanPercent / 100;
        }

        public bool CheckUserHistory()
        {
            Random random = new Random();
            bool randomBool = random.Next(2) == 1;
            return randomBool;
        }
    }
}
