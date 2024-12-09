using DesignPatterns.Lib.BuilderPattern;

namespace DesignPatternss.BuilderPattern.DiffInstitutions;

public class ExternalEmployeeBuilder : EmployeeBuilder
{
    public override void SetEmailAdress(string emailAdress)
    {
        Employee.EmailAdress = emailAdress;
    }

    public override void SetFullName(string fullName)
    {
        var arr = fullName.Split(new[] { ' ', '_', '.' });
        Employee.FirstName = arr[0];
        Employee.LastName = arr[1];
    }

    public override void SetUserName(string userName)
    {
        Employee.UserName = userName + "External.";
    }
}
