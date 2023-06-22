using NCalc;

namespace CalculatorApi.Services
{
    public class CalculatorService : ICalculatorService
    {
        public string calculate(string operation)
        {

           Expression expression = new Expression(operation);

            object result = expression.Evaluate();

            return result.ToString();


        }
    }
}
