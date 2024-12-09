namespace DesignPatternss.StrategyPattern;

public interface IPaymentService
{
    bool Pay(PaymentOptions paymentOptions);
}
