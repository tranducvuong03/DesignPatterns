namespace DesignPatterns.FactoryPattern
{
    public class PartTimeEmployee : Employee
    {
        public override decimal CalculateSalary()
        {
            return 12;
        }
    }
}
