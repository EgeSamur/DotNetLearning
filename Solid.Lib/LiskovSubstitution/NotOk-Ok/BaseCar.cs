using Solid.Lib.SingleResponsiblity;

namespace Solid.Lib.LiskovSubstitution.NotOk;

public class BaseCar
{
    public string x(DriverInfo driver)
    {
        return "";
    }

    public string SendSmsToDriver(DriverInfo driver)
    {
        if (driver.PhoneNumber != null)
            return "Send Sms.";
        else return "";
    }
}
public class Bmw : BaseCar
{

}
public class Mercedes : BaseCar
{

}

/*
 
 Aslında şuan burası Liskov'a uyuyor fakat 
 İleride Bmw Artık Driver'larına SMS göndermek istemediğini söyledi
 Bu durumda liskov ile çelişen bir durum yapanacak.
 Bu yüzden interfacelere ayırıcağız ve kalıtım aldığı her sınıfın özelliği taşımış olacak.
 */

public interface ISmsSendable
{
    string SendSmsToDriver(DriverInfo driver);

}

public interface IEmailSendable
{
    string SendEmailToDriver(DriverInfo driver);

}
public class BaseCarNew
{
    public string x(DriverInfo driver)
    {
        return "";
    }
   
}
public class BmwNew : BaseCarNew, IEmailSendable
{
    public string SendEmailToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }
}
public class MercedesNew : BaseCarNew, IEmailSendable, ISmsSendable
{
    public string SendEmailToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }
    public string SendSmsToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }
}

/*
    Bu durumda artık  her iki sınıfta kalıtım aldığı sınıfların tüm özelliklerine sahiptir.
 */