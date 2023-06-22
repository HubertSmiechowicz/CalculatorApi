using CalculatorApi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ICalculatorService _calculatorService;

        public CalculatorController(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        [HttpPost]
        public string calculate([FromBody] string operation)
        {
            return _calculatorService.calculate(operation);
        }
    }
}
