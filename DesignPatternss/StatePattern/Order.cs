namespace DesignPatternss.StatePattern;

public class OrderStatePattern
{
    public IOrderState State { get; set; }

    public OrderStatePattern()
    {
        State = new NewOrderState();
    }

    public void NextState()
    {
        State.Next(this);
    }
    public void PreviousState()
    {
        State.Previous(this);

    }
    public void PrintOrderState()
    {
        State.ProintStatus();
    }
}