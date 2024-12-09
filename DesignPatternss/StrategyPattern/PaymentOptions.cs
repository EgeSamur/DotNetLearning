namespace DesignPatternss.StrategyPattern;

public class PaymentOptions
{
    public string CardNumber { get; set; }
    public string CardHolderName { get; set; }
    public string Cvv { get; set; }
    public string ExpDate { get; set; }
    public decimal Amount { get; set; }
}
