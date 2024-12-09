namespace DesignPatternss.StatePattern;

record InProgressOrderState : IOrderState
{
    public void Next(OrderStatePattern order)
    {
        order.State = new OnTheWay();
    }

    public void Previous(OrderStatePattern order)
    {
        order.State = new NewOrderState();
    }

    public void ProintStatus()
    {
        Console.WriteLine("InProgressOrderState");
    }
}
