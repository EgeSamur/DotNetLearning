namespace DesignPatternss.ChainOfResponsibility;

// stock control -> payment -> Invoice -> Shipping

public class StockControl : IOrderHandler
{
    private IOrderHandler _next;
    public bool Handle(Order order)
    {
        bool stocAvaible = true;
        if (stocAvaible && _next is not null)
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

