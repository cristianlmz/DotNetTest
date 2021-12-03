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
            WriteJsonFile();
            Console.WriteLine("------------");
            RestApiCall(2);
            Console.WriteLine("------------");
            PrintYourName();
            Console.WriteLine("------------");
            FindMatches();
            Console.ReadLine();
        }

        /// <summary>
        /// Create the folder C:/DotNetTests/
        /// Generate the same json structure than JsonTests.json and write it in C:/DotNetTests/.
        /// Include all your models inside Models folder.
        /// </summary>
        void WriteJsonFile()
        {

        }

        /// <summary>
        /// Make a async request to an api and show the result paginated by 10.
        /// Measure the process time.
        /// Include all your models inside Models folder.
        /// </summary>
        /// <param name="pageNumber">Page number.</param>
        void RestApiCall(int pageNumber)
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
        }

        /// <summary>
        /// Write your full name in the variable "yourName".
        /// Print how many times each letter of your name appears in descending order.
        /// </summary>
        void PrintYourName()
        {
            string yourName = "";
        }

        /// <summary>
        /// Find the matches between these two lists.
        /// Print numbers divisible by 2 only.
        /// </summary>
        List<int> listA = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13 };
        List<int> listB = new List<int>() { 1, 3, 5, 6, 7, 9, 10, 12, 13, 20 };
        void FindMatches()
        {

        }
    }
}