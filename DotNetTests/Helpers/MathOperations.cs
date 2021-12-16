using Microsoft.Extensions.Logging;
using System;

namespace DotNetTests
{
    class MathOperations : iMath
    {
        private ILogger<MathOperations> _logger;

        public MathOperations(ILogger<MathOperations> logger)
        {
            _logger = logger;
        }

        public int Add(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Divide(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Multiply(int a, int b)
        {
            throw new NotImplementedException();
        }

        public int Subtract(int a, int b)
        {
            throw new NotImplementedException();
        }
    }
}
