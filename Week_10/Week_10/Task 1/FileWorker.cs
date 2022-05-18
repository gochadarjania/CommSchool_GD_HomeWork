using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10
{
    internal abstract class FileWorker
    {
        public int FileMaxSize { get; set; }
        public abstract string FileFormat { get; set; }

        public abstract void Read();

        public abstract void Write();

        public abstract void Edit();

        public abstract void Delete();
    }
}
