namespace DesignPatternss.StatePattern;

record NewOrderState : IOrderState
{
    public void Next(OrderStatePattern order)
    {
        order.State = new InProgressOrderState();
    }

    public void Previous(OrderStatePattern order)
    {
        Console.Write("Initial State");
    }
    public void ProintStatus()
    {
        Console.WriteLine("New Order");
    }
}
