using System;

namespace DotNetTests
{
    class Methods
    {
        ///What is the difference between these two switches? Do they work differently?
        public string DisplayNumber(int day)
        {
            var message = "";
            switch (day)
            {
                case 1:
                    message = "Number is " + day;
                    break;
                case 2:
                    message = string.Concat("Number is ", day);
                    break;
                case 3:
                    message = $"Number is {day}";
                    break;
                default:
                    break;
            }
            return message;
        }

        public string WhichDay(int day)
        {
            return day switch
            {
                1 => "Today is Monday",
                2 => "Today is Tuesday",
                3 => "Today is Wednesday",
                _ when day > 4 => "Other day",
                _ => string.Empty
            };
        }



        ///What is the difference between an Action, a Predicate and a Function?
        public Action<int> a = (number) => number++;
        public Predicate<int> b = (number) => number % 2 == 0;
        public Func<int, int, bool> c = (first, second) => first == second;



        /// All the lines of this method are executed?
        public int AddNumbers(string first, string second)
        {
            int a = ValidateString(first);
            int b = ValidateString(second);
            return a + b;
            int ValidateString(string number) => int.TryParse(number, out var value) ? AbsoluteValue(value) : 0;
            int AbsoluteValue(int number) => Math.Abs(number);
        }
    }
}
