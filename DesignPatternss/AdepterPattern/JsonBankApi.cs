namespace DesignPatternss.AdepterPattern;

public class JsonBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var json = $"""
            json: 
            """;
        Console.WriteLine($"{GetType().Name} worked.");
        return true;
    }
}
