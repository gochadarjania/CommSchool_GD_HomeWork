using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9
{
    internal class Student : BaseClass
    {
        public int Age { get; set; }
        public int Year { get; set; }

        public string GetRandomSubject()
        {
            List<string> subjects = new List<string>() { "Mathematics", "Chemistry", "English","Other Subject" };
            Random rand = new Random();
            string rndS = subjects[rand.Next(0,subjects.Count)];
            return rndS;
        }

        public int GetyYear(Student student)
        {
            int year = 4 - (DateTime.Now.Year - student.Year);

            return year;
        }
    }
}
