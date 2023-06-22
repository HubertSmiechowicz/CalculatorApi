using CalculatorApi.Models;

namespace CalculatorApi.Repositories
{
    public class FormulesRepository : IFormulesRepository
    {
        private List<FormuleModel> _formules = new List<FormuleModel>() {
            new FormuleModel("Pole kwadratu", "a^2"),
            new FormuleModel("Obwód kwadratu", "4 * a"),
            new FormuleModel("Pole trójkąta", "(1/2) * a * h"),
            new FormuleModel("Objętość sześcianu", "a^3"),
            new FormuleModel("Pole prostokąta", "a * b")
    } ;

        public List<FormuleModel> GetFormules()
        {
            return _formules;
        }
    }
}
