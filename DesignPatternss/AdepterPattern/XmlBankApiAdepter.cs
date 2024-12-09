namespace DesignPatternss.AdepterPattern;

public class XmlBankApiAdepter : IBankApi
{
    private readonly XmlBankApi _xmlBankApi;
    public XmlBankApiAdepter()
    {
        _xmlBankApi = new();
    }
    public bool ExecuteTransaction(TransferTransaction transaction)
    {
        return _xmlBankApi.ExecuteTransaction(transaction);
    }
}
