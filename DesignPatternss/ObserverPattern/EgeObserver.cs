namespace DesignPatternss.ObserverPattern;

public class EgeObserver : IObserver
{
    public string FullName { get; set; }
    public EgeObserver(string fullName)
    {
        FullName = fullName;
    }
    public void StockUpdate(Product product)
    {
        Console.WriteLine($"EgeObserver: {product.Name} is stock now {product.Price}");
    }
}

