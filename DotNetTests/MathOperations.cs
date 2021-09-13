using Microsoft.Extensions.Logging;
using System;

namespace DotNetTests
{
    class MathOperations : iMath
    {
        private ILogger<MathOperations> _logger;
        public int firstNumber = 2;
        public int secondNumber = -2;
        public int resultNumber;

        public MathOperations(ILogger<MathOperations> logger)
        {
            _logger = logger;
            firstNumber = 1;
            secondNumber = 0;
        }

        //a = 2
        //b = 7
        //result = 2
        public int Add(int a, int b)
        {
            firstNumber = a;
            resultNumber = firstNumber + Math.Abs(secondNumber);
            return resultNumber;
        }

        //a = 3
        //b = 8
        //result = 5
        public int Subtract(int a, int b)
        {
            int resultNumber = b - Add(a, b);
            return resultNumber;
        }

        //a = 5
        //b = 2
        //result = 5
        public int Multiply(int a, int b)
        {
            resultNumber = a * Subtract(b, firstNumber);
            return resultNumber;
        }

        //a = 9
        //b = 3
        //result = 1
        public int Divide(int a, int b)
        {
            Add(a, b);
            int resultNumber = Subtract(a, a) / Add(b, b);
            resultNumber = Divide(resultNumber, firstNumber);
            var methods = new Methods();
            return methods.c(resultNumber, firstNumber) ? 1 : 0;
        }

        //a = 8374
        //b = 59823
        //result = 500957802
        public double MultiplyWithOutMultiplyOperator(double a, double b)
        {
            double result = 0;
            return result;
        }
    }
}
