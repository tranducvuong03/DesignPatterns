namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    public class USEmployee : Employee
    {
        public USEmployee()
        {
        }

        public override decimal CalculateSalary()
        {
            return 6;
        }
    }
}
