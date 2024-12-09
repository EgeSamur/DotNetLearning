namespace DesignPatternss.ProxyPattern;

public interface ILogger
{
    void Log(string message);
    void Log(IEnumerable<string> messages);
}
