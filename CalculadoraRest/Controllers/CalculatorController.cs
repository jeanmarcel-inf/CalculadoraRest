using Microsoft.AspNetCore.Mvc;

namespace CalculadoraRest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        

        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        // Sum
        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult GetSum(string firstNumber, string secondNumber)
        {
            if(IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sum = Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber);
                return Ok(sum);
            }

            return BadRequest("Invalid Input");
        }

        // Subtraction
        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult GetSub(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var sub = Convert.ToDecimal(firstNumber) - Convert.ToDecimal(secondNumber);
                return Ok(sub);
            }

            return BadRequest("Invalid Input");
        }

        // Multiplication
        [HttpGet("multiply/{firstNumber}/{secondNumber}")]
        public IActionResult GetMultiply(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var mult = Convert.ToDecimal(firstNumber) * Convert.ToDecimal(secondNumber);
                return Ok(mult);
            }

            return BadRequest("Invalid Input");
        }

        // Division
        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult GetDivision(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var div = Convert.ToDecimal(firstNumber) / Convert.ToDecimal(secondNumber);
                return Ok(div);
            }

            return BadRequest("Invalid Input");
        }

        // Mean
        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult GetMean(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                var medium = (Convert.ToDecimal(firstNumber) + Convert.ToDecimal(secondNumber)) / 2;
                return Ok(medium);
            }

            return BadRequest("Invalid Input");
        }

        // Square Root
        [HttpGet("sqrt/{firstNumber}")]
        public IActionResult GetSqrt(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var sqrt = Math.Sqrt(Convert.ToDouble(firstNumber));
                return Ok(sqrt);
            }

            return BadRequest("Invalid Input");
        }

        private bool IsNumeric(string strNumber)
        {
            double number;

            bool isNumeric = double.TryParse(
                strNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number);

            return isNumeric;
        }
    }
}
