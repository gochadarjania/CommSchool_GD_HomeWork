using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9_Homework_3
{
    internal class Student
    {
        public string Name { get; set; }
        public virtual void Study()
        {
            Console.WriteLine("Student is Studying");
        }
        public virtual void Read()
        {
            Console.WriteLine("Student is Reading");
        }
        public virtual void Write()
        {
            Console.WriteLine("Student is Writing");
        }
        public virtual void Relax()
        {
            Console.WriteLine("Student is Relaxing");
        }
    }
}
