using System.Security.Cryptography.X509Certificates;

namespace DesignPatternss.SingletonPattern;

public class CountryProvider
{
    private static CountryProvider instance {  get; set; }

    // instance null ise oluşturulur değil ise atanır 
    public static CountryProvider Instance => instance ?? (instance = new CountryProvider());

    private new List<Country> Countries;
    private CountryProvider()
    {
        Countries =  new List<Country>()
        {
            new Country(){Name = "Türkiye"},
            new Country(){Name = "Birleşik Krallık"}
        };
    }
    public List<Country> GetCountries() => Countries;
    
}

