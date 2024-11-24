namespace Solid.Lib.DependencyInversion.NotOk;

public class TripInfoLogger
{
    public void LogToGermany(string message)
    {
        new GermanyLogger().Log(message);
    }
    public void LogToLocalStorage(string message)
    {
        new LocalStoregeLogger().Log(message);
    }
}

public class GermanyLogger 
{
    public void Log(string message)
    {
        // some log process
    }
}

public class LocalStoregeLogger
{
    public void Log(string message)
    {
        // some log process
    }
}

/*
 
    Bu durumda TripInfoLogger içerisinde kullandığı GermanyLogger ve LocalStorageLogger'a bağımlıdır
    bu prensibe uygun değildir
    ve yeni bir logger eklemek istediğimiz de de Trip info logger içerisinde değişiklik yapmamız gerekir
    liskova da uymaz 
 
 */
