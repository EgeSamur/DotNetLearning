namespace DesignPatternss.ProxyPattern;

public class FileLogger : ILogger
{
    public void Log(string message)
    {
        message = $"{DateTime.UtcNow}-{message}";
        File.AppendAllText("log.txt", message);
    }

    public void Log(IEnumerable<string> messages)
    {
        File.AppendAllText("messages.txt", string.Join(Environment.NewLine, messages));
    }
}
