using System;
using System.Collections.Generic;
using System.Linq;

namespace Week_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. S difference

            Console.WriteLine("Enter Diameter size");

            int x1 = Convert.ToInt32(Console.ReadLine())*2;
            int s1 = x1 * x1;

            var x2 = x1 * Math.Sqrt(2)/2; // 2a kvadrati = hipotenuzis kvadrats (pitagoras teorema)

            var s2 = Math.Round(x2 * x2);


            Console.WriteLine(s1 - s2);
            #endregion

            #region 2. Jackpot
            //List<string> usersValues = new List<string>();

            //while (true)
            //{
            //    Console.WriteLine("enter value");
            //    usersValues.Add(Console.ReadLine());

            //    Console.WriteLine("Do you want continue? y/n ");
            //    var x = Console.ReadLine();
            //    if (x=="n")
            //    {
            //        break;
            //    }

            //}

            //bool result = usersValues.Distinct().Count() == 1;

            //if (!result)
            //{
            //    Console.WriteLine("You can not win");
            //    return;
            //}
            //Console.WriteLine("You win Jackpot");


            #endregion

            #region 3. Football Scores

            //Console.WriteLine("Enter win:");

            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter draw:");

            //int b = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter lose:");

            //int c = Convert.ToInt32(Console.ReadLine());

            //int scoreSum = a * 3 + b * 1 + c * 0;

            //Console.WriteLine("Score: ");
            //Console.WriteLine(scoreSum);


            #endregion

            #region 4. Employee salary

            //List<string> weekString = new List<string>();

            //weekString.Add("Monday");
            //weekString.Add("Tuesday");
            //weekString.Add("Wednesday");
            //weekString.Add("Thursday");
            //weekString.Add("Friday");
            //weekString.Add("Saturday");
            //weekString.Add("Sunday");

            //List<int> weekInt = new List<int>();


            //for (int i = 0; i < weekString.Count; i++)
            //{
            //    Console.WriteLine($"Enter {weekString[i]} hours");

            //    int day = Convert.ToInt32(Console.ReadLine());

            //    if (day <= 8)
            //    {
            //        if (i > 4)
            //        {
            //            weekInt.Add(day * 2 * 10);
            //        }
            //        else
            //        {
            //            weekInt.Add(day * 10);

            //        }

            //    }

            //    if (day > 8)
            //    {
            //        int overTime = day - 8;

            //        if (i > 4)
            //        {
            //            weekInt.Add(overTime * 5 + 8 * 2 * 10);
            //        }
            //        else
            //        {
            //            weekInt.Add(overTime * 5 + 8 * 10);

            //        }

            //    }


            //}

            //Console.WriteLine("Sum Salary");

            //Console.WriteLine(weekInt.Sum(x => x));



            #endregion

            #region 5. Giorgi

            //List<int> weekInt = new List<int>();

            //bool exit = true;

            //while (exit)
            //{

            //    Console.WriteLine($"Enter the result of the day");

            //    int day = Convert.ToInt32(Console.ReadLine());
            //    weekInt.Add(day);

            //    Console.WriteLine("---------------------------");

            //    Console.WriteLine("Do you want continue? y/n ");
            //    var x = Console.ReadLine();
            //    if (x == "n")
            //    {
            //        exit=false;
            //    }
            //}

            //int result = 0;

            //for (int i = 1; i < weekInt.Count; i++)
            //{
            //    if (weekInt[i-1]<weekInt[i])
            //    {
            //        result++;
            //    }
            //}

            //Console.WriteLine($"Number of days of progress  {result}");

            #endregion

            #region 6. Print a word

            //List<string> words = new List<string>()
            //{
            //    "Hello",
            //    "World",
            //    "Programming",
            //    "communication"
            //};
            //Console.WriteLine("Enter lenght of words");

            //int len = Convert.ToInt32(Console.ReadLine());


            //foreach (var item in words.Where(x => x.Length >= len))
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
