namespace DesignPatternss.ProxyPattern;

// araya bir proxy koydum ve direkt file logger üzerinde işlem yapmıyoruz 
// Mesela çoklu loglamaya erişimi kısıtlamak istiyorum ve gidip exception fırtalabilirm.
public class BufferedFileLoggerProxy : ILogger
{
    private readonly FileLogger _fileLogger;
    private readonly int bufferSize;
    private List<string> logs;
    public void Log(string message)
    {
        logs.Add(message);
        if ( logs.Count > bufferSize)
        {   
            _fileLogger.Log(logs);
            logs.Clear();
        }
    }
    public void Log(IEnumerable<string> messages)
    {
        throw new NotImplementedException();
        //_fileLogger.Log(messages);
    }
}