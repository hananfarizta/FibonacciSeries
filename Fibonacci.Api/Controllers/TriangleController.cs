using Microsoft.AspNetCore.Mvc;
using Fibonacci.Domain.Services.Interfaces;

namespace Fibonacci.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FibonacciController : ControllerBase
    {
        private readonly IFibonacciService fibonacciService;

        public FibonacciController(IFibonacciService fibonacciService)
        {
            this.fibonacciService = fibonacciService;
        }

        [HttpGet]
        [Route("calculate")]
        public IActionResult CalculateFibonacci([FromQuery] int n)
        {
            try
            {
                if (n <= 0)
                {
                    return BadRequest("Input must be greater than 0.");
                }

                var fibonacciSequence = fibonacciService.GenerateFibonacciSequence(n);
                return Ok(fibonacciSequence);
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }
    }
}
