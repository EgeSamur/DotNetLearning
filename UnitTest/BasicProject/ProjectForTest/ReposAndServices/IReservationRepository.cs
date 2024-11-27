using ProjectForTest.Domain;

namespace ProjectForTest.ReposAndServices;

public interface IReservationRepository
{
    Reservation Add(Reservation reservation); // Yeni bir rezervasyon ekler.
    void Update(Reservation reservation); // Mevcut bir rezervasyonu günceller.
    void Delete(int id); // Bir rezervasyonu siler.
    Reservation GetById(int id); // ID'ye göre rezervasyonu getirir.
    List<Reservation> GetAll(); // Tüm rezervasyonları listeler.
    List<Reservation> GetReservationsByCarId(int carId); // Belirli bir araç için rezervasyonları getirir.
}
