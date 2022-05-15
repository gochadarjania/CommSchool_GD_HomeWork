using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_9.Enum;

namespace Week_9
{
    internal class Company
    {

        public CompanyEnum CompanyType { get; set; }
        public decimal GetCalculateMoney(Company companyType, int totalAmount)
        {
            decimal calculateMony = 0;

            if (companyType.CompanyType == CompanyEnum.Foreign)
            {
                calculateMony += totalAmount * 5 / 100;
            }
            else
            {
                calculateMony += totalAmount * 18 / 100;                
            }

            return calculateMony;
        }
    }
}
