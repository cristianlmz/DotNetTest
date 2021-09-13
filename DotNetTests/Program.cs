using System;
using System.Collections.Generic;

namespace DotNetTests
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("DotNet tests.");
            //Console.WriteLine("------------");
            //MathOperations();
            //Console.WriteLine("------------");
            //SortArray();
            //Console.WriteLine("------------");
            //FindMatches();
            //Console.WriteLine("------------");
            Console.ReadLine();
        }

        /// <summary>
        /// Multiply two numbers without using the multiply operator. Measure execution time.
        /// </summary>
        void MathOperations()
        {
            //var math = new MathOperations();
            //int a = 8374;
            //int b = 59823;
            //var multiply = a * b;
            //var withOutOperator = math.MultiplyWithOutMultiplyOperator(a, b);
            //Console.WriteLine($"Are equal = {multiply == withOutOperator}");
        }

        /// <summary>
        /// Linq. Sort the array and print the number of occurrences of each number. Print numbers in descending order.
        /// </summary>
        int[] numbersArray = { 1, 4, 1, 2, 7, 2, 2, 6, 3, 1, 2, 3, 1, 5, 2, 5, 1, 6, 4, 2, 8, 1, 4, 2, 3, 4, 5, 6, 4, 3, 7, 5, 3, 3, 1, 1 };
        void SortArray()
        {
        }

        /// <summary>
        /// Linq. Find the matches of the two lists and print the numbers divisible by 2.
        /// Print numbers in both lists.
        /// Print numbers divisible by 2
        /// </summary>
        List<int> listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> listB = new List<int>() { 1, 3, 5, 6, 7, 9, 10 };
        void FindMatches()
        {
        }
    }
}