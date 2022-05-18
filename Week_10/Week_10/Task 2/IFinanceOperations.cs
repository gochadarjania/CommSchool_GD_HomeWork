using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10
{
    internal interface IFinanceOperations
    {
        int CalculateLoanPercent(int month, int loanAmount);
        bool CheckUserHistory();
    }
}
