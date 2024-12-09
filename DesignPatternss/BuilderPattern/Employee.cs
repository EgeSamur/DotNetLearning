namespace DesignPatterns.Lib.BuilderPattern;

public class Employee
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string EmailAdress { get; set; }
    public string UserName { get; set; }

    override public string ToString()
    {
        return $"{FirstName} {LastName} {EmailAdress}";
    }
}
