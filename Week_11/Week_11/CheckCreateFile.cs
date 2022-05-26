using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_11
{
    class CheckCreateFile
    {
        public string InputFilePath { get; set; }

        //@"C:\Users\user\source\repos\Week_11\Week_11\MyFiles\file.txt"

        public CheckCreateFile(string inputFilePath = @"C:\Users\user\source\repos\Week_11\Week_11\MyFiles\file.txt")
        {
            this.InputFilePath = inputFilePath;
        }

        public void CheckFile(int count)
        {
            if (!File.Exists(InputFilePath)) { File.CreateText(InputFilePath); }//if exsist
            for (int i = 0; i < count; i++)
            {
                var rndWord = GetRandomWord();
                File.AppendAllText(InputFilePath, rndWord + Environment.NewLine);
                if (i == count-1)//print last element
                {
                    Console.WriteLine(rndWord);
                }
            }
        }

        private  string GetRandomWord()
        {
            var words = new List<string>() { "Hello", "Good", "Look", "Apple", "Car", "Name" };
            var rnd= new Random();
            var rndIndex = rnd.Next(words.Count());
            var rndWord = words[rndIndex];
            return rndWord;
        }

    }
}
