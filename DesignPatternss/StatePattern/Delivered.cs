namespace DesignPatternss.StatePattern;

record Delivered : IOrderState
{
    public void Next(OrderStatePattern order)
    {
        Console.Write("Initial State");

    }

    public void Previous(OrderStatePattern order)
    {
        order.State = new OnTheWay();
    }
    public void ProintStatus()
    {
        Console.WriteLine("Delivered");
    }
}
