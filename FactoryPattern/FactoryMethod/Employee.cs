namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    public abstract class Employee
    {
        public void PaySalaries()
        {
            decimal salary = CalculateSalary();
            Console.WriteLine($"Paying salary: {salary:C}");
        }

        public abstract decimal CalculateSalary();
    }

    public enum EmployeeType
    {
        FullTime,
        PartTime,
        Intern
    }
}
