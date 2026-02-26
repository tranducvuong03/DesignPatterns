namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    public class FullTimeEmployee : Employee
    {
        public override decimal CalculateSalary()
        {
            return 12;
        }
    }
}
