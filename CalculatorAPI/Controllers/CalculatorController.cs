using Microsoft.AspNetCore.Mvc;
using CalculatorAPI.Interfaces; // Import the interface namespace

namespace CalculatorAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ICalculatorService<double> _calculatorService;

        // Constructor injection of the calculator service
        public CalculatorController(ICalculatorService<double> calculatorService)
        {
            _calculatorService = calculatorService;
        }

        // Example action methods using the calculator service

        [HttpGet("add")]
        public ActionResult<double> Add(double firstOperand, double secondOperand)
        {
            var result = _calculatorService.Sum(firstOperand, secondOperand);
            return Ok(result);
        }

        [HttpGet("subtract")]
        public ActionResult<double> Subtract(double firstOperand, double secondOperand)
        {
            var result = _calculatorService.Difference(firstOperand, secondOperand);
            return Ok(result);
        }

        [HttpGet("multiply")]
        public ActionResult<double> Multiply(double firstOperand, double secondOperand)
        {
            var result = _calculatorService.Product(firstOperand, secondOperand);
            return Ok(result);
        }

        [HttpGet("divide")]
        public ActionResult<double> Divide(double firstOperand, double secondOperand)
        {
            try
            {
                var result = _calculatorService.Quotient(firstOperand, secondOperand);
                return Ok(result);
            }
            catch (DivideByZeroException ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}