namespace Fibonacci.Domain.Services.Interfaces
{
    public interface IFibonacciService
    {
        int CalculateFibonacci(int n);
        List<int> GenerateFibonacciSequence(int n);
    }
}
