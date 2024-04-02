using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBotHelpers;

public static class Messages
{
    public static Message? SendText(ITelegramBotClient client, Update update, CancellationToken ctoken)
    {
        try
        {
            return null;
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}