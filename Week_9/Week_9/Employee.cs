using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_9.Enum;

namespace Week_9
{
    internal class Employee
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public RoleEnum Role { get; set; }
        public List<int> HourseOfWork { get; set; }

        public int GetSumSalary(Employee employee)
        {
            List<int> weekInt = new List<int>();

            var hourse = employee.HourseOfWork;
            int countHourse = 0;

            for (int i = 0; i < hourse.Count; i++)
            {
                int day = hourse[i];
                countHourse += day;
                int minSalary = 10;
                if (employee.Role == RoleEnum.Manager) { minSalary = 40; }
                if (employee.Role == RoleEnum.Developer) { minSalary = 30; }
                if (employee.Role == RoleEnum.Tester) { minSalary = 20; }
                if (day <= 8)
                {
                    if (i > 4)
                    {
                        weekInt.Add(day * 2 * minSalary);
                    }
                    else
                    {
                        weekInt.Add(day * minSalary);
                    }
                }

                if (day > 8)
                {
                    int overTime = day - 8;
                    if (i > 4)
                    {
                        weekInt.Add(overTime * 5 + 8 * 2 * minSalary);
                    }
                    else
                    {
                        weekInt.Add(overTime * 5 + 8 * minSalary);
                    }
                }
            }
            Console.WriteLine("Sum Salary");
            int sum = weekInt.Sum(x => x);

            if (countHourse > 50)
            {
                sum += sum * 20/100; 
            }
            return sum;
        }

    }

}
