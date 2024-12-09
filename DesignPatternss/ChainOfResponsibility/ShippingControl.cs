namespace DesignPatternss.ChainOfResponsibility;

public class ShippingControl : IOrderHandler
{
    private IOrderHandler _next;
    public bool Handle(Order order)
    {
        bool shippingSucceded = true;
        if (shippingSucceded && _next is not null)
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

