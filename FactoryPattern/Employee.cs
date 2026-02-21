namespace DesignPatterns.FactoryPattern
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
}
