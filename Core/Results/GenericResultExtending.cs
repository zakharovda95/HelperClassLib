namespace Core.Results;

public class GenericResultExtending<T> : GenericResult
{
    public T? Data { get; set; }
    public Exception? Exception { get; set; }
}