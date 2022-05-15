using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_9_Homework_3
{
    internal class LazyStudent : Student
    {
        public override void Study()
        {
            Console.WriteLine("LazyStudent is Studying");
        }
        public override void Read()
        {
            Console.WriteLine("LazyStudent is Reading");
        }
        public override void Write()
        {
            Console.WriteLine("LazyStudent is Writing");
        }
        public override void Relax()
        {
            Console.WriteLine("LazyStudent is Relaxing");
        }
    }
}
