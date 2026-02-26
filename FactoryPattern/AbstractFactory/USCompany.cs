using DesignPatterns.FactoryPattern.FactoryMethod;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    public class USCompany : ICompanyFactory
    {
        public Employee CreateEmployee() => new USEmployee();
    }
}
