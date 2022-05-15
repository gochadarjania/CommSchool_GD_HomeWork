using System;
using System.Collections.Generic;

namespace Week_9_Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<Student> students = new List<Student>()
            {
                new Student(){Name ="Gio"},
                new Student(){Name ="Giga"},
                new Student(){Name ="Zvio"},
                new Student(){Name ="Elene"},
                new Student(){Name ="Salome"}
            };

            ClassRoom classRoom = new ClassRoom(students);
            classRoom.AllStudentsAllMethod(classRoom);
        }
    }
}
