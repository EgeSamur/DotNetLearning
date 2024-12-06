using ProjectForTest.Domain;

namespace ProjectForTest.ReposAndServices;

public class ReservationService
{
    private readonly IReservationRepository _reservationRepository;
    private readonly ICarRepository _carRepository;

    public ReservationService(IReservationRepository reservationRepository, ICarRepository carRepository)
    {
        _reservationRepository = reservationRepository;
        _carRepository = carRepository;
    }

    public Reservation CreateReservation(Reservation reservation)
    {
        var car = _carRepository.GetById(reservation.CarId);
        if (car == null || car.IsRented || car.IsUnderMaintenance)
            throw new InvalidOperationException("Car is not available for reservation.");

        car.IsRented = true;
        _carRepository.Update(car);

        reservation.TotalPrice = (reservation.EndDate - reservation.StartDate).Days * car.DailyRentalPrice;
        return _reservationRepository.Add(reservation);
    }
}
