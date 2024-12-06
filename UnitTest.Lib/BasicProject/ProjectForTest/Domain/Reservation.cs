namespace ProjectForTest.Domain;

public class Reservation
{
    public int Id { get; set; }
    public int CarId { get; set; }
    public string CustomerName { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal TotalPrice { get; set; }
}


