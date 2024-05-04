using Core.Results;
using Telegram.Bot.Types;

namespace TgBotHelpers.System.Interfaces;

public interface IMessage
{
    public Task<GenericResultExtending<Message>?> Send(string text, bool reply = true, bool markdownMode = false);
    // public Task<GenericResultExtending<Message>> Edit();
}