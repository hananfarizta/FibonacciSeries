using Fibonacci.Domain.Services.Interfaces;

namespace Fibonacci.Domain.Services.Implementation
{
    public class FibonacciService : IFibonacciService
    {
        public int CalculateFibonacci(int n)
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

        public List<int> GenerateFibonacciSequence(int n)
        {
            if (n <= 0)
            {
                throw new ArgumentException("Input must be greater than 0.", nameof(n));
            }

            List<int> sequence = new List<int>();
            int prev = 1;
            int current = 1;

            sequence.Add(prev);
            sequence.Add(current);

            for (int i = 3; i <= n; i++)
            {
                int result = prev + current;
                sequence.Add(result);
                prev = current;
                current = result;
            }

            return sequence;
        }
    }
}
