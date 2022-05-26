using System;
using System.IO;


namespace Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileFormat = @"C:\Users\user\source\repos\Week_11\Task_6\MyFiles\ZipFormat.zip";


            string ext = Path.GetExtension(fileFormat);
            Context context;
            if (ext == ".zip")
            {
                context = new Context(new ZipFile());
                context.ContextInterface(fileFormat);
            }
            if (ext == ".json")
            {
                context = new Context(new JsonFile());
                context.ContextInterface(fileFormat);
            }
            if (ext == ".txt")
            {
                context = new Context(new TxtFile());
                context.ContextInterface(fileFormat);
            }
        }

        class Context
        {
            Strategy strategy;
            public Context(Strategy strategy)
            {
                this.strategy = strategy;
            }
            public void ContextInterface(string fileFormat)
            {
                strategy.AlgorithmInterface(fileFormat);
            }
        }
        abstract class Strategy
        {
            public abstract void AlgorithmInterface(string fileFormat);
        }
        class ZipFile : Strategy
        {
            public override void AlgorithmInterface(string fileFormat)
            {
                var rootDirectory = new DirectoryInfo(fileFormat).Parent.FullName;
                var backUpFile = "Backup";
                var backUpPath = Path.Combine(rootDirectory, backUpFile);
                if (!Directory.Exists(backUpPath))
                {
                    Directory.CreateDirectory(backUpPath);
                }
                Console.WriteLine(backUpPath);
                System.IO.Compression.ZipFile.ExtractToDirectory(fileFormat, backUpPath);
            }
        }
        class JsonFile : Strategy
        {
            public override void AlgorithmInterface(string fileFormat)
            {
                StreamReader read = new StreamReader(fileFormat);
                string jsonString = read.ReadToEnd();
                Console.WriteLine(jsonString);
            }
        }
        class TxtFile : Strategy
        {
            public override void AlgorithmInterface(string fileFormat)
            {
                File.Delete(fileFormat);
            }
        }
    }
}
