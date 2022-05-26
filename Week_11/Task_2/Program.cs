using System;
using System.Collections.Generic;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number: ");
            var number = Convert.ToInt32(Console.ReadLine());
            Numbers(number);
        }
        static void Numbers(int number)
        {
            var inputFilePath = @"C:\Users\user\source\repos\Week_11\Task_2\MyFiles\file.txt";

            if (!File.Exists(inputFilePath)) { File.CreateText(inputFilePath); }//if exsist

            List<List<string>> matrix = new List<List<string>>();

            for (int i = 1; i <= number; i++)
            {
                List<string> list1 = new List<string>();

                for (int j = 1; j < 10; j++)
                {
                    var line = $"{i}* {j} = {i * j} |";
                    list1.Add(line);
                }

                matrix.Add(list1);
            }


            for (int i = 0; i < matrix[0].Count; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < matrix.Count; j++)
                {
                    Console.Write(matrix[j][i]);

                    string result = matrix[j][i];

                    File.AppendAllText(inputFilePath, result);
                }
                File.AppendAllText(inputFilePath, Environment.NewLine);
            }
        }
    }
}
