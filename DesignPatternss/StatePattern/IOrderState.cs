namespace DesignPatternss.StatePattern;

// yeni sipariş , işleniyor, kargoya verildi, teslim edildi
public interface IOrderState
{
    void Next(OrderStatePattern order);
    void Previous(OrderStatePattern order);
    void ProintStatus();
}
