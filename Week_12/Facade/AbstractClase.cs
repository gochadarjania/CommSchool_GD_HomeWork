using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public abstract class AbstractFormat
    {
        public abstract AbstractFormat CreateFormat(AbstractFormat format);
        public abstract void Print();
    }
}
