namespace Solid.Lib.SingleResponsiblity.Ok;

public class BaseCar
{
    public string SendEmailToDriver(DriverInfo driver)
    {
        if (driver.Email != null)
            return "Send Email.";
        else return "";
    }

    public string SendSmsToDriver(DriverInfo driver)
    {
        if (driver.PhoneNumber != null)
            return "Send Sms.";
        else return "";
    }
}

/*
 
 Eğer base kar içinde başka işlemler de olacak olsaydı  
 bu metodlar başka bir class içerisinde tanımlanırdı 
 bir class bir işlemi bir metod bir işlemi yapmalı 
 bir işlemi aynı yerde yapabilecek olmamız yapmamız gerektiğini göstermez prensibi.

 */