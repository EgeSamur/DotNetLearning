namespace DesignPatterns.Lib.BuilderPattern;

public interface IEmployeeBuilder
{
    public void SetFullName(string fullName);
    public void SetEmailAdress(string emailAdress);
    public void SetUserName(string userName);
    public Employee BuildEmployee();
}
