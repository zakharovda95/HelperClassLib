using Core.Results;
using TgBotHelpers.System.Interfaces;

namespace TgBotHelpers.Messages;

public abstract class Message : IMessage
{
    public abstract Task<GenericResultExtending<Telegram.Bot.Types.Message>?> Send(string text, bool reply = true,
        bool markdownMode = false);
}