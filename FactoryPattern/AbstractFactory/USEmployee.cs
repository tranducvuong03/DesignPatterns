using DesignPatterns.FactoryPattern.FactoryMethod;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    public class USEmployee : Employee
    {
        public override decimal CalculateSalary() => 50000m;
    }
}
