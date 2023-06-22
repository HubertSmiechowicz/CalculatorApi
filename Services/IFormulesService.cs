using CalculatorApi.Models;

namespace CalculatorApi.Services
{
    public interface IFormulesService
    {
        List<FormuleModel> GetFormules();
    }
}