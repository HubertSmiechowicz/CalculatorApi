using CalculatorApi.Models;
using CalculatorApi.Repositories;

namespace CalculatorApi.Services
{
    public class FormulesService : IFormulesService
    {
        private readonly IFormulesRepository _formulesRepository;

        public FormulesService(IFormulesRepository formulesRepository)
        {
            _formulesRepository = formulesRepository;
        }

        public List<FormuleModel> GetFormules()
        {
            return _formulesRepository.GetFormules();
        }
    }
}
