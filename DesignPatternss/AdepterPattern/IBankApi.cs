namespace DesignPatternss.AdepterPattern;

public interface IBankApi
{
    bool ExecuteTransaction(TransferTransaction transaction);
}