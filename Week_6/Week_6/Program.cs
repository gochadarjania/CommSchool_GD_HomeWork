using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Even and odd

            //Console.WriteLine("Enter Lenght of Array");

            //var lengthEnter = Console.ReadLine();

            //int lengthArr;

            //bool lenghtParss = int.TryParse(lengthEnter, out lengthArr);

            //int[] array = null;

            //if (lenghtParss)
            //{
            //    array = new int[lengthArr];

            //    for (int i = 0; i < lengthArr; i++)
            //    {
            //        array[i] = i + 1;
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("entered value is not number");
            //}

            //int even = 0;
            //int odd = 0;

            //if (array != null)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % 2 == 0)
            //        {
            //            even++;
            //        }

            //    }

            //    odd = array.Length - even;

            //    int[] evenArr = new int[even];
            //    int[] oddArr = new int[odd];

            //    int o = 0;
            //    int e = 0;

            //    for (int i = 0; i < array.Length; i++)
            //    {

            //        if (array[i] % 2 == 0)
            //        {
            //            evenArr[e] = array[i];
            //            e++;
            //        }
            //        else
            //        {
            //            oddArr[o] = array[i];
            //            o++;
            //        }

            //    }
            //    Console.WriteLine(" ");

            //    Console.WriteLine("-Even Number-");

            //    foreach (var item in evenArr)
            //    {

            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("-------------------");

            //    Console.WriteLine(" ");
            //    Console.WriteLine("-Odd Number-");

            //    foreach (var item in oddArr)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}



            #endregion
            #region Number of elements and Sum


            //bool input = true;

            //List<int> numbers = new List<int>();

            //while (input)
            //{
            //    Console.WriteLine("Enter Number");

            //    var numberEnter = Console.ReadLine();

            //    int numberResult;

            //    bool numberParss = int.TryParse(numberEnter, out numberResult);

            //    if (numberParss)
            //    {
            //        numbers.Add(numberResult);
            //    }
            //    else
            //    {
            //        Console.WriteLine("entered value is not number");
            //    }

            //    Console.WriteLine("Enter to continue: y\nExit: n");
            //    var exit = Console.ReadLine();
            //    Console.WriteLine("------------------------");
            //    if (exit=="n")
            //    {
            //        input = false;
            //    }
            //}

            //var result = from number in numbers
            //             group number by number into y
            //             select y;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key} appears {item.Count()} times {item.Sum(x=>x)} Sum");
            //    Console.WriteLine();
            //}

            #endregion
            #region Top N Numbers

            //List<int> numbers = new List<int>();

            //Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{
            //    numbers.Add(random.Next(100));
            //}

            //Console.WriteLine("Enter Top N");

            //var topNumber = Convert.ToInt32(Console.ReadLine());

            //var numbersDes = numbers.OrderByDescending(x => x);

            //var numberTops = numbersDes.Take(topNumber);
            //Console.WriteLine("-----------------");
            //Console.WriteLine($"Top {topNumber} Numbers");
            //Console.WriteLine("-----------------");

            //foreach (var item in numberTops)
            //{
            //    Console.WriteLine(item);
            //};


            #endregion
        }
    }
}
