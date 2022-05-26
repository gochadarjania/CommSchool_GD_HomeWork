using Newtonsoft.Json;
using System;
using System.IO;

namespace Task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var myJson = @"C:\Users\user\source\repos\Week_11\Task_5\JsonFile.json";

            StreamReader read = new StreamReader(myJson);
            string jsonString = read.ReadToEnd();

            JsonFile jsonFile = JsonConvert.DeserializeObject<JsonFile>(jsonString);
            int key = jsonFile.key;

            string word = "";

            int length = jsonFile.word.Length;

            for (int i = 0; i < length; i++)
            {
                var current = i + key;

                if (current>= length)
                {
                    current -= length;
                }
                word += jsonFile.word[current];

            }

            Console.WriteLine(word);
        }
    }
}
