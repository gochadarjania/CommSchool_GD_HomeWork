using System;
using System.Collections.Generic;
using Week_9.Enum;

namespace Week_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TestCompanyTask();
            //EmployeeSeed();
            //StudentSeed();
            TeacherSeed();
        }

        public static void CompanySeed()
        {
            Company companyLocal = new Company();
            companyLocal.CompanyType = CompanyEnum.Local;

            Company companyForeign = new Company();
            companyForeign.CompanyType = CompanyEnum.Foreign;

            var comp1 = companyLocal.GetCalculateMoney(companyLocal, 100);
            var comp2 = companyForeign.GetCalculateMoney(companyForeign, 100);

            Console.WriteLine(comp1);
            Console.WriteLine(comp2);
        }
        public static void EmployeeSeed()
        {
            Employee employee = new Employee();
            employee.Name = "Gocha";
            employee.Age = 25;
            employee.LastName = "Darjania";
            employee.Role = RoleEnum.Developer;
            employee.HourseOfWork = new List<int>() { 8,8,8,8,8,0,0};

            Console.WriteLine(employee.GetSumSalary(employee));
        }
        public static void StudentSeed()
        {
            Student student = new Student() { Name = "Giga", Age = 21, Year = 2021 };
            Console.WriteLine(student.GetRandomSubject());
            Console.WriteLine(student.GetyYear(student));
        }
        public static void TeacherSeed()
        {
            Student student = new Student() { Name = "Giga", Age = 21, Year = 2021 };
            Teacher teacher = new Teacher() { Name = "Nino", Status = 1 };
            var result = teacher.CheckSubject(student);
            Console.WriteLine(result);
        }
    }
}
