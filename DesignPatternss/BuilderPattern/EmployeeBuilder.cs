namespace DesignPatterns.Lib.BuilderPattern;

public abstract class EmployeeBuilder : IEmployeeBuilder
{
    public Employee Employee { get; set; }

    public EmployeeBuilder()
    {
        Employee = new Employee();
    }
    public abstract void SetFullName(string fullName);
    public abstract void SetEmailAdress(string emailAdress);
    public abstract void SetUserName(string userName);

    public Employee BuildEmployee()
    {
        return Employee;
    }
}
