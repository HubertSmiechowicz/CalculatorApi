using CalculatorApi.Models;
using CalculatorApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormulesController : Controller
    {
        private readonly IFormulesService _formulesService;

        public FormulesController(IFormulesService formulesService)
        {
            _formulesService = formulesService;
        }

        [HttpGet]
        public List<FormuleModel> GetFormules() 
        {
            return _formulesService.GetFormules();
        }
    }
}
