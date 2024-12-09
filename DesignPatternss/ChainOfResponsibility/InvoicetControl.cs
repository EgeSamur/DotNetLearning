namespace DesignPatternss.ChainOfResponsibility;

public class InvoicetControl : IOrderHandler
{
    private IOrderHandler _next;
    public bool Handle(Order order)
    {
        bool invoiceCreated = true;
        if (invoiceCreated && _next is not null)
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

