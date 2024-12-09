namespace DesignPatternss.StrategyPattern;

public class IsBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("İş Bankası ile ödeme alındı");
        return true;
    }
}
