namespace Solid.Lib.DependencyInversion.Ok;

public interface ILogger
{
    void Log(string message);
}

public class TripInfoLogger
{
    private ILogger _logger { get; set; }
    public TripInfoLogger(ILogger logger)
    {
        _logger = logger;
    }
}

public class GermanyLogger : ILogger
{
    public void Log(string message)
    {
        // some log process
    }
}

public class LocalStoregeLogger : ILogger
{
    public void Log(string message)
    {
        // some log process
    }
}

/*
 
    Bu şekilde artık herhangi bir alt sınıfa bağımlılık oratadan kalkıyor
    yeni bir logger eklemek istersek o da ILogger dan türeyecek ve yine bağımlılık oluşmayacak.
 
 */