using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10.Task_1
{
    internal class ChildFileWorker : FileWorker
    {
        string _fileFormat = "";
        public override string FileFormat { get => _fileFormat; set => _fileFormat = value; }
        public override void Read()
        {
            Console.WriteLine($"I can read to {_fileFormat} file with max storage {FileMaxSize}");
        }

        public override void Write()
        {
            Console.WriteLine($"I can write to {_fileFormat} file with max storage {FileMaxSize}");
        }

        public override void Edit()
        {
            Console.WriteLine($"I can edit to {_fileFormat} file with max storage {FileMaxSize}");
        }

        public override void Delete()
        {
            Console.WriteLine($"I can delete to {_fileFormat} file with max storage {FileMaxSize}");
        }
    }
}
