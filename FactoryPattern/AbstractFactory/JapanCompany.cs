using DesignPatterns.FactoryPattern.FactoryMethod;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    public class JapanCompany : ICompanyFactory
    {
        public Employee CreateEmployee() => new JapanEmployee();
    }
}
