namespace DesignPatterns.FactoryPattern
{
    public class FullTimeEmployee : Employee
    {
        public override decimal CalculateSalary()
        {
            return 12;
        }
    }
}
