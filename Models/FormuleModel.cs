namespace CalculatorApi.Models
{
    public class FormuleModel
    {
        public string name { get; private set; }
        public string formule { get; private set; }

        public FormuleModel(string name, string formule) 
        {
            this.name = name;
            this.formule = formule;
        }
    }
}
