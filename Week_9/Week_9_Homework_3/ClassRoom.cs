using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9_Homework_3
{
    internal class ClassRoom
    {
        List<Student> students;
        public ClassRoom(List<Student> students)
        {
            this.students = students;
        }
        public void AllStudentsAllMethod(ClassRoom classRoom)
        {
            for (int i = 0; i < classRoom.students.Count; i++)
            {
                var student = classRoom.students[i];
                
                Console.WriteLine(student.Name);
                student.Study();
                student.Write();
                student.Read();
                student.Relax();
                Console.WriteLine(new string('-',30));
            }
        }
    }
}
