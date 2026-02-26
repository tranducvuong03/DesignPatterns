namespace DesignPatterns.FactoryPattern.FactoryMethod
{
    public static class EmployeeFactory
    {
        public static Employee Create(EmployeeType type)
        {
            return type switch
            {
                EmployeeType.FullTime => new FullTimeEmployee(),
                EmployeeType.PartTime => new JapanEmployee(),
                EmployeeType.Intern => new USEmployee(),
                _ => throw new ArgumentException("Invalid employee type")
            };
        }
    }
}
