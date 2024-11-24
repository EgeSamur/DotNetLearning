using Solid.Lib.SingleResponsiblity;

namespace Solid.Lib.InterfaceSegregation.NotOk_Ok;

public interface ISmsSendable
{
    string SendSmsToDriver(DriverInfo driver);
    
}

public interface IEmailSendable
{
    string SendEmailToDriver(DriverInfo driver);

}
public class BmwNew : IEmailSendable
{
    public string SendEmailToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }
}
public class MercedesNew : IEmailSendable, ISmsSendable
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
 
    EmailSendable interfacemize toplu e mail göndermek için bir method eklenecek.
    Fakat Bmw bu özelliği istemediğini belirtti 
 
    Aşağıda Interface Segregation'a uymayan kod örneği
 */
public interface IEmailSendablenNew
{
    string SendEmailToDriver(DriverInfo driver);
    string SendEmailToDriver(IList<DriverInfo> drivers);

}
public class Bmw : IEmailSendable
{
    public string SendEmailToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }
    public string SendEmailToDriver(IList<DriverInfo> drivers)
    {
        throw new NotImplementedException();
    }
}
public class Mercedes : IEmailSendable, ISmsSendable
{
    public string SendEmailToDriver(IList<DriverInfo> drivers)
    {
        throw new NotImplementedException();
    }
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
    Olması gereken yeni bir intarface kullanılması
    böylece liskov prensibini de bozmamış oluyoruz.
 
     Bu şekilde interfaceler içerisine eklenen özellik o interfaceden kalıtılan tüm sınıflarda kullanılır oluyor.
 */
public interface IMultibleEmailSendablen
{
    string SendEmailToDriver(IList<DriverInfo> drivers);

}
public class BmwNewNew : IEmailSendable
{
    public string SendEmailToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }

}
public class MercedesNewNew : IEmailSendable, ISmsSendable , IMultibleEmailSendablen
{
    public string SendEmailToDriver(IList<DriverInfo> drivers)
    {
        throw new NotImplementedException();
    }
    public string SendEmailToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }
    public string SendSmsToDriver(DriverInfo driver)
    {
        throw new NotImplementedException();
    }
}