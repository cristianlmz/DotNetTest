using System;
using System.Collections.Generic;

namespace DotNetTests
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("DotNet tests.");
            Console.WriteLine("------------");
            //MathOperations();
            //Console.WriteLine("------------");
            //SortArray();
            //Console.WriteLine("------------");
            //FindMatches();
            //Console.WriteLine("------------");
            //RestApiCall(2);
            //Console.WriteLine("------------");
            //WriteJsonFile();
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
        /// Sort the array and print the number of occurrences of each number. 
        /// Print numbers in descending order by their occurrences.
        /// </summary>
        int[] numbersArray = { 1, 4, 1, 2, 7, 2, 2, 6, 3, 1, 2, 3, 1, 5, 2, 5, 1, 6, 4, 2, 8, 1, 4, 2, 3, 4, 5, 6, 4, 3, 7, 5, 3, 3, 1, 1 };
        void SortArray()
        {

        }

        /// <summary>
        /// Find the matches between two lists.
        /// Print numbers divisible by 2 only.
        /// </summary>
        List<int> listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        List<int> listB = new List<int>() { 1, 3, 5, 6, 7, 9, 10 };
        void FindMatches()
        {

        }

        /// <summary>
        /// Make a async request to an api and show the result paginated by 10.
        /// </summary>
        /// <param name="pageNumber">Page number.</param>
        void RestApiCall(int pageNumber)
        {
            //var url = "https://jsonplaceholder.typicode.com/posts";
        }

        /// <summary>
        /// Create the folder C:/DotNetTests/
        /// Generate the same json structure than JsonTests.json and write it in C:/DotNetTests/.
        /// </summary>
        void WriteJsonFile()
        {

        }
    }
}