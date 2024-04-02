
namespace ResultHelpers;

public struct GenericReturnResult<T>
{
    public bool IsSuccess { get; init; }
    public string? Message { get; init; }
    public T Data { get; init; }
}