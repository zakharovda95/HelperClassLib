
using ExceptionHelpers;

namespace ResultHelpers;

public struct GenericReturnResult<T>
{
    public bool IsSuccess { get; init; }
    public string? Title { get; init; }
    public string? Message { get; init; }
    public GenericCustomException? Exception { get; init; }
    public T? Data { get; init; }
}