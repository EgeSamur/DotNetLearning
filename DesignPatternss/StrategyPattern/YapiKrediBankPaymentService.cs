namespace DesignPatternss.StrategyPattern;

public class YapiKrediBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Yapı Kredi Bankası ile ödeme alındı");
        return true;
    }
}
