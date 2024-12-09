namespace DesignPatternss.ChainOfResponsibility;

public interface IOrderHandler
{
    bool Handle(Order order);
    void SetNext(IOrderHandler next);
}
