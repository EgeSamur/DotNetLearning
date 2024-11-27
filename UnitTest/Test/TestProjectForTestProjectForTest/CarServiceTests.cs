using FluentAssertions;
using Moq;
using ProjectForTest.Domain;
using ProjectForTest.ReposAndServices;

namespace TestProjectForTestProjectForTest;

[TestFixture]
public class CarServiceTests
{
    private Mock<ICarRepository> _mockCarRepository;
    private CarService _carService;

    [SetUp]
    public void SetUp()
    {
        _mockCarRepository = new Mock<ICarRepository>();
        _carService = new CarService(_mockCarRepository.Object);
    }

    [Test]
    public void AddCar_InvalidBrand_ThrowsArgumentException()
    {
        var car = new Car { Brand = "", Model = "Model S", DailyRentalPrice = 100 };

        Action act = () => _carService.AddCar(car);

        act.Should().Throw<ArgumentException>().WithMessage("Brand and Model cannot be empty.");
    }

    [Test]
    public void AddCar_ValidCar_ReturnsCar()
    {
        var car = new Car { Brand = "Tesla", Model = "Model S", DailyRentalPrice = 200 };

        _mockCarRepository.Setup(repo => repo.Add(It.IsAny<Car>())).Returns(car);

        var result = _carService.AddCar(car);

        result.Should().NotBeNull();
        result.Brand.Should().Be("Tesla");
        result.Model.Should().Be("Model S");
        result.DailyRentalPrice.Should().Be(200);
    }

    [Test]
    public void GetAvailableCars_ReturnsOnlyAvailableCars()
    {
        var cars = new List<Car>
        {
            new Car { Id = 1, Brand = "Tesla", Model = "Model S", IsRented = false, IsUnderMaintenance = false },
            new Car { Id = 2, Brand = "BMW", Model = "i8", IsRented = true, IsUnderMaintenance = false },
            new Car { Id = 3, Brand = "Audi", Model = "A4", IsRented = false, IsUnderMaintenance = true }
        };

        _mockCarRepository.Setup(repo => repo.GetAll()).Returns(cars);

        var result = _carService.GetAvailableCars();

        result.Should().HaveCount(1);
        result.First().Brand.Should().Be("Tesla");
        result.First().Model.Should().Be("Model S");
    }
}
