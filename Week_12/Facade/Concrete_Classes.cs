using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Html : AbstractFormat
    {
        public override AbstractFormat CreateFormat(AbstractFormat html)
        {
            return html;
        }
        public override void Print()
        {
            Console.WriteLine(@"<header> My Header </header>
<body> 
Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add.
</body> 
<footer> My Footer </footer>
");
        }
    }
    class PDF : AbstractFormat
    {
        public override AbstractFormat CreateFormat(AbstractFormat pdf)
        {
            return pdf;
        }

        public override void Print()
        {
            Console.WriteLine(@"Header :  I’m using Facade Pattern
Body : 
Video provides a powerful way to help you prove your point. When you click Online Video, you can paste in the embed code for the video you want to add. You can also type a keyword to search online for the video that best fits your document. To make your document look professionally produced, Word provides 
Footer:  Page 1

");
        }
    }
    public class Client
    {
        private AbstractFormat _format;
        public Client(AbstractFormat format)
        {
            _format = format.CreateFormat(format);
        }

        public void Run()
        {
            _format.Print();
        }
    }
}
