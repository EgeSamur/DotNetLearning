namespace DesignPatternss.StrategyPattern;

public class GarantiBankPaymentService : IPaymentService
{
    public bool Pay(PaymentOptions paymentOptions)
    {
        Console.WriteLine("Garanti Bankası ile ödeme alındı");
        return true;
    }
}
