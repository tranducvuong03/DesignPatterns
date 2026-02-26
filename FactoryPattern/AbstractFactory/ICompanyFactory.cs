using DesignPatterns.FactoryPattern.FactoryMethod;

namespace DesignPatterns.FactoryPattern.AbstractFactory
{
    public interface ICompanyFactory
    {
        Employee CreateEmployee();
    }
}
