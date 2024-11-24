
namespace Solid.Lib.OpenClose.NotOk;


public class BaseCar
{
    public double TripKm { get; set; }
}
public class Bmw : BaseCar
{

}
public class Mercedes : BaseCar
{

}

#region Yeni Eklenirse
public class Toyota : BaseCar
{

}
#endregion

public class FuelCostCalculator
{
    public double FuelCost(BaseCar car)
    {
        if (car is Bmw) return car.TripKm * 2;
        if (car is Mercedes) return car.TripKm * 3;

        #region Toyota eklendiğinde burayı yazmak lazım değiştirilmeme özelliğine aykırı
        if (car is Toyota) return car.TripKm * 0.75;
        #endregion
        else return car.TripKm * 0;
    }
}