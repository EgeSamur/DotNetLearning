namespace DesignPatternss.ChainOfResponsibility;

public class PaymentControl : IOrderHandler
{
    private IOrderHandler _next;
    public bool Handle(Order order)
    {
        bool paymnetSucces = true;
        if (paymnetSucces && _next is not null)
        {
            return _next.Handle(order);
        }
        return false;
    }
    public void SetNext(IOrderHandler next)
    {
        _next = next;
    }
}

