using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10.Task_2
{
    internal class MicroFinance : BaseBank, IFinanceOperations
    {
        public int CalculateLoanPercent(int month, int loanAmount)
        {
            var loanPercent = 10;
            var monthAmount = loanAmount / month;//Monthly amount 
            var montPercentAmount = monthAmount * loanPercent / 100;//amount of interest for 1 month 
            var percenAmountSum = montPercentAmount * month;//Percent Sum 
            var serviceAmountSum = month * 4;//Monthly service amount sum
            var totalAmount = serviceAmountSum + percenAmountSum;

            return totalAmount;
        }

        public bool CheckUserHistory()
        {
            return true;
        }
    }
}
