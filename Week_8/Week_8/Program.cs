using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MinMaxN(48,71,2);
            FindSocks("AABBCC");
            CommonInWords("Some Random Text", "It is Some Random Text");

            List<int> listInt = new List<int>() { 2,3,4,5,6,7};
            List<string> listString = new List<string>() { "test", "random", "programming", "word" };
            List<bool> listBool = new List<bool>() { true, false, true, false, true, false, false };

            GenericTypeOfList(listBool);

            PrintNumber(120345);

        }

        static void MinMaxN(int min, int max, int n)
        {
            List<int> numbersPow = new List<int>(); //შევქმენით მასივი ახარისხებული რიცხვებისთვის

            for (int i = 0; i < max; i++)// 0 დან მაქსამდე აგვყავს ხარისხში და ვამატებთ მასივში
            {
                numbersPow.Add((int)Math.Pow(i, n));
            }

            int counter = 0;

            for (int i = min; i < max; i++) // მინიდან მაქსამდე ვამოწმებთ, თუ არის მასივში ეს რიცხვები
            {
                if (numbersPow.FirstOrDefault(x => x == i) != 0)
                {
                    counter++;
                }
            }

            Console.WriteLine($"{counter} numbers found");

        }

        static void FindSocks(string socks)
        {
            List<char> socksList = new List<char>();//შემოტანილი სტრინგის სიმბოლოებისთვის

            for (int i = 0; i < socks.Length; i++)//ჩამატების პროცესი
            {
                socksList.Add(socks[i]);
            }

            //var sockLength = socksList.Distinct().Count();

            var result = from sockLength in socksList //დაჯგუფება სიმბოლოების, უნიკალური მნიშვნელობისთვის
                         group sockLength by sockLength into y
                         select y;

            int counter = 0;//წყვილის მთვლელი

            foreach (var item in result) 
            {
                if (socksList.FindAll(x => x == item.Key).Count() >1)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }

        static void CommonInWords(string firstWord, string secondWord)
        {

            string resultReverse = "";//შემოტანილი სიტყვების, საერთო, შეტრიალებული ვარიანტი

            string firstWordArray = Reverse(firstWord);
            string secondWordArray = Reverse(secondWord);

            Console.WriteLine(Reverse(firstWord).ToString());

            int length = 0;

            //გავიგოთ რომლის სიგრძეა ნაკლები
            if (firstWord.Length > secondWord.Length)
            {
                length = secondWord.Length;
            }
            else
            {
                length = firstWord.Length;
            }


            //შედარება
            for (int i = 0; i < length; i++)
            {
                if (firstWordArray[i] == secondWordArray[i])
                {
                    Console.WriteLine(firstWordArray[i]);
                    resultReverse += firstWordArray[i].ToString();
                }
            }

            //საბოლოო შედეგი
            string result = Reverse(resultReverse);

            Console.WriteLine(result);
        }

        static string Reverse(string s)
        {
            List<char> charArray = new List<char>();
            charArray.AddRange(s.ToCharArray());
            charArray.Reverse();

            string result = "";

            for (int i = 0; i < charArray.Count(); i++)
            {
                result += charArray[i];
            }

            return result;
        }

        static void GenericTypeOfList<T>(List<T> list)
        {
            List<int> integer = new List<int>();

            Type type = list.GetType();

            if (type == typeof(List<int>))
            {
                var result = list.Select(x => Convert.ToInt32(x)).ToList();

                int sum = result.Sum(x => x);

                Console.WriteLine(sum);
            }
            
            if(type == typeof(List<string>))
            {
                var result = list.Select(x => Convert.ToString(x)).ToList();

                for (int i = 0; i < result.Count; i++)
                {
                    Console.WriteLine(result[i].ToUpper());
                }
            }

            if (type == typeof(List<bool>))
            {
                var result = list.Select(x => Convert.ToBoolean(x)).ToList();

                Console.WriteLine($"first Element is {result[0]}");
                Console.WriteLine($"Last Element is {result[result.Count-1]}");
                Console.WriteLine($"Middle Element is {result[result.Count/2]}");

            }
        }

        static void PrintNumber(decimal number)//12345
        {
            if (number!=0)
            {
                var x = number % 10;
                Console.WriteLine(x);
                number *= 0.1m;
                PrintNumber((int)number);

            }
        }
    }
}
