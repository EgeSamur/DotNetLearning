using ProjectForTest.Domain;

namespace ProjectForTest.ReposAndServices;

public interface ICarRepository
{
    Car Add(Car car); // Yeni bir araç ekler.
    void Update(Car car); // Var olan bir aracı günceller.
    void Delete(int id); // Bir aracı siler (soft-delete olarak düşünebilirsin).
    Car GetById(int id); // ID'ye göre aracı getirir.
    List<Car> GetAll(); // Tüm araçları listeler.
}
