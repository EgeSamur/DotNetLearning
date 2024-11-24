namespace Solid.Lib.SingleResponsiblity.NotOk;

public class BaseCar
{
    public string SendEmailOrSmsToDriver(DriverInfo driver)
    {
        if (driver.Email != null)
            return "Send Email.";
        else if (driver.PhoneNumber != null)
            return "Send SMS.";
        else return "";
    }
}

