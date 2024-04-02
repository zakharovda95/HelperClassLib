using ExtensionHelpers;

namespace ExceptionHelpers;

public readonly struct GenericCustomException(short code, string title, string message, Exception innerException)
{
    public short Code { get; init; } = code;
    public string Title { get; init; } = title;
    public string Message { get; init; } = message;
    public Exception? InnerException { get; init; } = innerException;
}