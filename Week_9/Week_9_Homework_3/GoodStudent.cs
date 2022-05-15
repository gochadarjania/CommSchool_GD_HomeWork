using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9_Homework_3
{
    internal class GoodStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("GoodStudent is Studying");
        }
        public override void Read()
        {
            Console.WriteLine("GoodStudent is Reading");
        }
        public override void Write()
        {
            Console.WriteLine("GoodStudent is Writing");
        }
        public override void Relax()
        {
            Console.WriteLine("GoodStudent is Relaxing");
        }
    }
}
