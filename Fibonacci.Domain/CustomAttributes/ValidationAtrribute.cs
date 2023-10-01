using System.ComponentModel.DataAnnotations;

namespace Fibonacci.Domain.CustomAttributes
{
    public class CalculateFibonacciAttribute : ValidationAttribute
    {
        public CalculateFibonacciAttribute()
        {
            ErrorMessage = "Input is not a valid Fibonacci number.";
        }

        public override bool IsValid(object value)
        {
            if (value is int n)
            {
                int fibN = CalculateFibonacci(n);
                return fibN == n;
            }

            return false;
        }

        private static int CalculateFibonacci(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Input must be greater than 0.", nameof(n));
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            int prev = 1;
            int current = 1;
            int result = 0;

            for (int i = 3; i <= n; i++)
            {
                result = prev + current;
                prev = current;
                current = result;
            }

            return result;
        }
    }
}
