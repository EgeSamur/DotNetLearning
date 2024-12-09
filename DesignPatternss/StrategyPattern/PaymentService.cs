namespace DesignPatternss.StrategyPattern;
public class PaymentService
{
    private IPaymentService _paymentService;
    public PaymentService()
    {
    }
    public PaymentService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }
    public bool PayViaStrategy(PaymentOptions paymentOptions)
    {
        return _paymentService.Pay(paymentOptions);
    }
    public void SetPaymentService(IPaymentService paymentService)
    {
        _paymentService = paymentService;
    }
}