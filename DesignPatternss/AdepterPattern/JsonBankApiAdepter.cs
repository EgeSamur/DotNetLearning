namespace DesignPatternss.AdepterPattern;

public class JsonBankApiAdepter : IBankApi
{
    private readonly JsonBankApi _jsonBankApi;
    public JsonBankApiAdepter()
    {
        _jsonBankApi = new();
    }
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _jsonBankApi.ExecuteTransaction(transaction);
    }
}
