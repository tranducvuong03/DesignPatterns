using DesignPatterns.FactoryPattern.FactoryMethod;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    public class JapanEmployee : Employee
    {
        public override decimal CalculateSalary() => 5000m;
    }
}
