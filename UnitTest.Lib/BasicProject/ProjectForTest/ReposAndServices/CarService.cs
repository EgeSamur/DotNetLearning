using ProjectForTest.Domain;

namespace ProjectForTest.ReposAndServices;

public class CarService
{
    private readonly ICarRepository _carRepository;

    public CarService(ICarRepository carRepository)
    {
        _carRepository = carRepository;
    }

    public Car AddCar(Car car)
    {
        if (string.IsNullOrWhiteSpace(car.Brand) || string.IsNullOrWhiteSpace(car.Model))
            throw new ArgumentException("Brand and Model cannot be empty.");

        if (car.DailyRentalPrice <= 0)
            throw new ArgumentException("Daily rental price must be greater than zero.");

        return _carRepository.Add(car);
    }

    public List<Car> GetAvailableCars()
    {
        return _carRepository.GetAll()
            .Where(c => !c.IsRented && !c.IsUnderMaintenance)
            .ToList();
    }

    public void UpdateCar(Car car)
    {
        var existingCar = _carRepository.GetById(car.Id);
        if (existingCar == null)
            throw new KeyNotFoundException("Car not found.");

        existingCar.Brand = car.Brand;
        existingCar.Model = car.Model;
        existingCar.DailyRentalPrice = car.DailyRentalPrice;

        _carRepository.Update(existingCar);
    }
}
