using Newtonsoft.Json;
using System;
using System.IO;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var myJson = @"C:\Users\user\source\repos\Week_11\Task_4\BirthDate.json";

            StreamReader read = new StreamReader(myJson);
            string jsonString = read.ReadToEnd();

            BirhtData birhtData = JsonConvert.DeserializeObject<BirhtData>(jsonString);
            var day = birhtData.birthDate - birhtData.currentDate;
            Console.WriteLine($"There are {day.Days} days left until the birthday");

        }

        class BirhtData
        {
            public DateTime currentDate { get; set; }
            public DateTime birthDate { get; set; }
        }
    }
}
