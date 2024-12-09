namespace DesignPatternss.AdepterPattern;

public class XmlBankApi : IBankApi
{
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        var xml = $"""
            <TransferTransaction>
                <FromIBAN>{transaction.FromIBAN}</FromIBAN>
                <ToIBAN>{transaction.toIban}</ToIBAN>
                <Amount>{transaction.Amount}</Amount>
            </TransferTransaction>
            """;
        Console.WriteLine($"{GetType().Name} worked.");
        return true;
    }
}
