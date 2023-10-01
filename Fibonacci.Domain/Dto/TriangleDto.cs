using System.ComponentModel.DataAnnotations;
using Fibonacci.Domain.CustomAttributes;

namespace Fibonacci.Domain.Dto
{
    [CalculateFibonacci]
    public class TriangleDto
    {
        [Required]
        [Range(0, int.MaxValue)]
        public int Value { get; set; }
    }
}
