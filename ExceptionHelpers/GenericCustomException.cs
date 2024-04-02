

namespace ExceptionHelpers;

public struct GenericCustomException
{
    public GenericCustomException(GECodeEnum errorData, Exception innerException, string message)
    {
        Message = message;
    }
    
    public short Code { get; init; }
    public string Message { get; init; }
    public Exception? InnerException { get; init; }
}