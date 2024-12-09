namespace DesignPatternss.StatePattern;

record OnTheWay : IOrderState
{
    public void Next(OrderStatePattern order)
    {
        order.State = new Delivered();
    }

    public void Previous(OrderStatePattern order)
    {
        order.State = new InProgressOrderState();
    }

    public void ProintStatus()
    {
        Console.WriteLine("OnTheWay");
    }
}
