using FluentAssertions;
using Moq;
using ProjectForTest.Domain;
using ProjectForTest.ReposAndServices;

namespace TestProjectForTestProjectForTest;

[TestFixture]
public class ReservationServiceTests
{
    private Mock<IReservationRepository> _mockReservationRepository;
    private Mock<ICarRepository> _mockCarRepository;
    private ReservationService _reservationService;

    [SetUp]
    public void SetUp()
    {
        _mockReservationRepository = new Mock<IReservationRepository>();
        _mockCarRepository = new Mock<ICarRepository>();
        _reservationService = new ReservationService(_mockReservationRepository.Object, _mockCarRepository.Object);
    }

    [Test]
    public void CreateReservation_CarNotAvailable_ThrowsInvalidOperationException()
    {
        var reservation = new Reservation
        {
            CarId = 1,
            CustomerName = "John Doe",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(3)
        };

        _mockCarRepository.Setup(repo => repo.GetById(It.IsAny<int>()))
            .Returns(new Car { Id = 1, IsRented = true });

        Action act = () => _reservationService.CreateReservation(reservation);

        act.Should().Throw<InvalidOperationException>().WithMessage("Car is not available for reservation.");
    }

    [Test]
    public void CreateReservation_ValidReservation_ReturnsReservation()
    {
        var car = new Car
        {
            Id = 1,
            Brand = "Tesla",
            Model = "Model S",
            DailyRentalPrice = 150,
            IsRented = false,
            IsUnderMaintenance = false
        };

        var reservation = new Reservation
        {
            CarId = 1,
            CustomerName = "John Doe",
            StartDate = DateTime.Now,
            EndDate = DateTime.Now.AddDays(2)
        };

        _mockCarRepository.Setup(repo => repo.GetById(It.IsAny<int>())).Returns(car);
        _mockReservationRepository.Setup(repo => repo.Add(It.IsAny<Reservation>())).Returns(reservation);

        var result = _reservationService.CreateReservation(reservation);

        result.Should().NotBeNull();
        result.TotalPrice.Should().Be(300); // 2 gün x 150 TL
        result.CustomerName.Should().Be("John Doe");
    }
}
