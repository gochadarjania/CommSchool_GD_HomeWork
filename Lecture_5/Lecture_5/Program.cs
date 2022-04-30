using System;

namespace Lecture_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Divide 5

            //Console.WriteLine("Enter Number: ");

            //var inputNumber = Convert.ToInt32(Console.ReadLine());

            //if (inputNumber % 5 == 0)
            //{
            //    Console.WriteLine($"Input: {inputNumber} Output: Yes");
            //}
            //else
            //{
            //    Console.WriteLine($"Input: {inputNumber} Output: No");

            //}

            #endregion

            #region 2. Sum, difference, multiplication, division

            //Console.WriteLine("Enter First Number: ");

            //var firstNumber = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine("Enter Sexond Number: ");

            //var secondNumber = Convert.ToDecimal(Console.ReadLine());

            //Console.WriteLine($"X = {firstNumber} Y = {secondNumber} \n--------------");//write inputed numbers

            //var sum = firstNumber + secondNumber;
            //var multiplication = firstNumber * secondNumber;

            //Console.WriteLine($"X+Y = {sum} \nX*Y = {multiplication}");//write numbers Sum and Multiplication

            //decimal difference = 0;
            //decimal division = 0;

            //Console.WriteLine();

            //if (firstNumber > secondNumber)
            //{
            //    difference = firstNumber - secondNumber;
            //    Console.WriteLine($"X-Y = {difference}");//write numbers difference


            //    if (secondNumber != 0)
            //    {
            //        division = firstNumber / secondNumber;
            //        Console.WriteLine($"X/Y = {division}");//write numbers division

            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Allowed To Divide By Zero");
            //    }
            //}
            //else
            //{
            //    difference = secondNumber - firstNumber;

            //    Console.WriteLine($"Y-X = {difference}");//write numbers difference

            //    if (firstNumber == 0)
            //    {
            //        Console.WriteLine("Not Allowed To Divide By Zero");
            //    }
            //    else
            //    {
            //        division = secondNumber / firstNumber;

            //        Console.WriteLine($"Y/X = {division}");//write numbers division

            //    }
            //}


            #endregion

            #region 3. Exchange numbers

            //Console.WriteLine("Enter X Number: ");

            //var x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Y Number: ");

            //var y = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"X = {x} Y = {y}");

            //x += y;

            //y = x - y;

            //x = x - y;

            //Console.WriteLine($"X = {x} Y = {y}");


            #endregion

            #region 4. multiplication table

            //Console.WriteLine("Enter number");
            //var x = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Input {x}");

            //for (int i = 1; i < 10; i++)
            //{
            //    var multiplication = x * i;
            //    Console.WriteLine($"5 * {i} = {multiplication}");
            //}

            #endregion

            #region 5. Even numbers squared

            Console.WriteLine("Enter number");
            var x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Input {x}");

            for (int i = 2; i < x; i+=2)
            {
                var result = Math.Pow(i,2);

                Console.WriteLine(result);
            }

            #endregion
        }
    }
}
