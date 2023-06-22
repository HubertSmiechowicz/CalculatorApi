using CalculatorApi.Models;

namespace CalculatorApi.Repositories
{
    public interface IFormulesRepository
    {
        List<FormuleModel> GetFormules();
    }
}