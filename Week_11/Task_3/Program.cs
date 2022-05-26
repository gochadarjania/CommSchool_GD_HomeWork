using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "programming 2";
            List<string> list = new List<string>();
            list = text.Split(" ").ToList();

            string firstEle = "";
            string secondEle = "";
            List<string> elementList = new List<string>();

            int countElement = Convert.ToInt32(list[1]);


            int count = list[0].Length / 2;

            for (int i = 0; i < list[0].Length; i++)
            {
                if (i <= count)
                {
                    firstEle += list[0][i];
                }
                else
                {
                    secondEle += list[0][i];
                }
            }
            elementList.Add(firstEle);
            elementList.Add(secondEle);


            Console.WriteLine(firstEle);
            Console.WriteLine(secondEle);



            var myXml = @"C:\Users\user\source\repos\Week_11\Task_3\MyXml.xml";
            var doc = new XmlDocument();
            doc.Load(myXml);

            for (int i = 0; i < countElement; i++)
            {

                XmlElement elem = doc.CreateElement(elementList[i]);
                elem.InnerText = $"string {i}";

                doc.DocumentElement.AppendChild(elem);
                doc.Save(myXml);

            }
        }
    }
}
