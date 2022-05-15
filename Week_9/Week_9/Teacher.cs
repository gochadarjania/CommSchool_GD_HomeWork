using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9
{
    internal class Teacher : BaseClass
    {
        public byte Status { get; set; }

        public string CheckSubject(Student student)
        {
            var subject = student.GetRandomSubject();
            string result;
            Random rand = new Random();

            if (subject == "Mathematics")
            {
                int x = rand.Next(100);
                int y = rand.Next(100);
                result = (x + y).ToString();
            }
            else if (subject == "Chemistry")
            {
                result = "H2O";
            }
            else if (subject == "English")
            {
                result = "Hello World";
            }
            else
            {
                result = "Not competent!";
            }
            return result;
        }
    }
}
