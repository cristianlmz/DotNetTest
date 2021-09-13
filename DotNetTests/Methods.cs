using System;

namespace DotNetTests
{
    class Methods
    {
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
                case 4:
                    message = string.Format("Number is {0}", day);
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
                _ => "Other day"
            };
        }

        public int SelectValue(int number)
        {
            return number switch
            {
                _ when number > 10 => 5,
                _ when number <= 10 => 17,
                _ => 0
            };
        }

        public int AddNumbers(string first, string second)
        {
            int a = ValidateString(first);
            int b = ValidateString(second);
            return a + b;
            int ValidateString(string number) => int.TryParse(number, out var value) ? AbsoluteValue(value) : 0;
            int AbsoluteValue(int number) => Math.Abs(number);
        }

        public Action<int> a = (number) => number++;

        public Predicate<int> b = (number) => number % 2 == 0;

        public Func<int, int, bool> c = (first, second) => first == second;
    }
}
