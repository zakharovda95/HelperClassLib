namespace TgBotHelpers;

public record struct MenuItemModel
{
    public string Command { get; init; }
    public string Text { get; init; }
    public string? Url { get; init; }
    public string? Value { get; init; }
}