namespace ProjectForTest.Domain;

public class Car
{
    public int Id { get; set; }
    public string Brand { get; set; }
    public string Model { get; set; }
    public string PlateNumber { get; set; }
    public bool IsRented { get; set; }
    public bool IsUnderMaintenance { get; set; }
    public decimal DailyRentalPrice { get; set; }
}


