using System;

namespace Week_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Testing();
        }

        public static void Testing()
        {

            Console.WriteLine("Enter Quantity of Lines:");
            int inputLine;//out value
            var numberCheck = int.TryParse(Console.ReadLine(), out inputLine);// check number type
            var checkFile = new CheckCreateFile(@"C:\Users\user\source\repos\file.txt");//can you other address of file
            if (numberCheck)
            {
                checkFile.CheckFile(inputLine);//check file and append inputLine words
            }
            else
            {
                Console.WriteLine("Please enter only number!");
            }
        }
    }
}
