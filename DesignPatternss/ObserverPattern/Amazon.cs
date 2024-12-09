namespace DesignPatternss.ObserverPattern;

public class Amazon
{
    private Dictionary<IObserver, Product> observers = new Dictionary<IObserver, Product>();
    public void Register(IObserver observer, Product product)
    {   
        observers.TryAdd(observer, product);
    }
    public void UnRegister(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyAll()
    {
        foreach (var observer in observers)
        {
            observer.Key.StockUpdate(observer.Value);
        }
    }

    public void NotifyProductName(string productName)
    {
        foreach (var observer in observers)
        {
            if (observer.Value.Name == productName)
            {
                observer.Key.StockUpdate(observer.Value);
            }
        }
    }
}

