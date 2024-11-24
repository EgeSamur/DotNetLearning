namespace Solid.Lib.OpenClose.Ok
{
    public abstract class BaseCar
    {
        public double TripKm { get; set; }

        // Abstraction ile bunun her alt sınıfta override ederek 
        // ne kadar yakıt yaktığını döndürebiliriz.
        public abstract double GetCostPerKm();
       
    }
    public class Bmw : BaseCar
    {
        public override double GetCostPerKm()
        {
            return 2;
        }
    }
    public class Mercedes : BaseCar
    {
        public override double GetCostPerKm()
        {
            return 3;
        }
    }

    #region Yeni Eklenirse
    public class Toyota : BaseCar
    {
        public override double GetCostPerKm()
        {
            return 0.75;
        }
    }
    #endregion

    public class FuelCostCalculator
    {
        public double FuelCost(BaseCar car)
        {
            return car.TripKm * car.GetCostPerKm();
        }
    }
}

/*
 
 Bu şekilde abstraction kullanarak her defasında Fuel cost içerisinde 
 değişime izin vermeyip yeni base car tipinde arabalar eklendikçe 
 gelişime açık bir tasarım kullanmış olduk.
 
 */