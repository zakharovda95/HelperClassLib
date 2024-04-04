using ExceptionHelpers;
using ExtensionHelpers;
using ResultHelpers;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace TgBotHelpers;

public static class Messages
{
    public static async Task<GenericReturnResult<Message?>> SendText(ITelegramBotClient client, Update update,
        CancellationToken ctoken, string message, bool reply = false)
    {
        try
        {
            var chatId = update.Message?.Chat.Id ?? update.CallbackQuery?.From.Id;

            if (chatId == null)
            {
                return new GenericReturnResult<Message?>
                {
                    IsSuccess = false,
                    Title = GRMessages.NoChatId.GetDisplayName(),
                    Message = GRMessages.NoChatId.GetDisplayDescription()
                };
            }

            var result = await client.SendTextMessageAsync(
                chatId: chatId,
                text: message,
                cancellationToken: ctoken,
                replyToMessageId: reply ? null : update.Message?.MessageId,
                parseMode: ParseMode.Markdown
            );

            return new GenericReturnResult<Message?>
            {
                IsSuccess = true,
                Title = GRMessages.BotSuccessSending.GetDisplayName(),
                Message = GRMessages.BotSuccessSending.GetDisplayDescription(),
                Data = result
            };
        }
        catch (Exception e)
        {
            return new GenericReturnResult<Message?>
            {
                IsSuccess = false,
                Exception = new GenericCustomException(
                    code: (short)GECodeEnum.BotWrongSending.GetDisplayOder(),
                    title: GECodeEnum.BotWrongSending.GetDisplayName(),
                    message: GECodeEnum.BotWrongSending.GetDisplayDescription(),
                    innerException: e)
            };
        }
    }
    public static async Task<GenericReturnResult<Message?>> SendReplyKeyboard(ITelegramBotClient client, Update update,
        CancellationToken ctoken, string message, ReplyKeyboardMarkup keyboard, bool reply = false)
    {
        try
        {
            var chatId = update.Message?.Chat.Id ?? update.CallbackQuery?.From.Id;

            if (chatId == null)
            {
                return new GenericReturnResult<Message?>
                {
                    IsSuccess = false,
                    Title = GRMessages.NoChatId.GetDisplayName(),
                    Message = GRMessages.NoChatId.GetDisplayDescription()
                };
            }

            var result = await client.SendTextMessageAsync(
                chatId: chatId,
                text: message,
                cancellationToken: ctoken,
                replyToMessageId: reply ? null : update.Message?.MessageId,
                replyMarkup: keyboard,
                parseMode: ParseMode.Html
            );

            return new GenericReturnResult<Message?>
            {
                IsSuccess = true,
                Title = GRMessages.BotSuccessSending.GetDisplayName(),
                Message = GRMessages.BotSuccessSending.GetDisplayDescription(),
                Data = result
            };
        }
        catch (Exception e)
        {
            return new GenericReturnResult<Message?>
            {
                IsSuccess = false,
                Exception = new GenericCustomException(
                    code: (short)GECodeEnum.BotWrongSending.GetDisplayOder(),
                    title: GECodeEnum.BotWrongSending.GetDisplayName(),
                    message: GECodeEnum.BotWrongSending.GetDisplayDescription(),
                    innerException: e)
            };
        }
    }
    
    public static async Task<GenericReturnResult<Message?>> SendInlineKeyboard(ITelegramBotClient client, Update update,
        CancellationToken ctoken, string message, InlineKeyboardMarkup keyboard, bool reply = false)
    {
        try
        {
            var chatId = update.Message?.Chat.Id ?? update.CallbackQuery?.From.Id;

            if (chatId == null)
            {
                return new GenericReturnResult<Message?>
                {
                    IsSuccess = false,
                    Title = GRMessages.NoChatId.GetDisplayName(),
                    Message = GRMessages.NoChatId.GetDisplayDescription()
                };
            }

            var result = await client.SendTextMessageAsync(
                chatId: chatId,
                text: message,
                cancellationToken: ctoken,
                replyToMessageId: reply ? null : update.Message?.MessageId,
                replyMarkup: keyboard,
                parseMode: ParseMode.Html
            );

            return new GenericReturnResult<Message?>
            {
                IsSuccess = true,
                Title = GRMessages.BotSuccessSending.GetDisplayName(),
                Message = GRMessages.BotSuccessSending.GetDisplayDescription(),
                Data = result
            };
        }
        catch (Exception e)
        {
            return new GenericReturnResult<Message?>
            {
                IsSuccess = false,
                Exception = new GenericCustomException(
                    code: (short)GECodeEnum.BotWrongSending.GetDisplayOder(),
                    title: GECodeEnum.BotWrongSending.GetDisplayName(),
                    message: GECodeEnum.BotWrongSending.GetDisplayDescription(),
                    innerException: e)
            };
        }
    }
    public static async Task<GenericReturnResult<Message?>> RemoveKeyboard(ITelegramBotClient client, Update update,
        CancellationToken ctoken, string message, bool reply = false)
    {
        try
        {
            var chatId = update.Message?.Chat.Id ?? update.CallbackQuery?.From.Id;

            if (chatId == null)
            {
                return new GenericReturnResult<Message?>
                {
                    IsSuccess = false,
                    Title = GRMessages.NoChatId.GetDisplayName(),
                    Message = GRMessages.NoChatId.GetDisplayDescription()
                };
            }

            var result = await client.SendTextMessageAsync(
                chatId: chatId,
                text: message,
                cancellationToken: ctoken,
                replyToMessageId: reply ? null : update.Message?.MessageId,
                replyMarkup: new ReplyKeyboardRemove()
            );

            return new GenericReturnResult<Message?>
            {
                IsSuccess = true,
                Title = GRMessages.BotSuccessSending.GetDisplayName(),
                Message = GRMessages.BotSuccessSending.GetDisplayDescription(),
                Data = result
            };
        }
        catch (Exception e)
        {
            return new GenericReturnResult<Message?>
            {
                IsSuccess = false,
                Exception = new GenericCustomException(
                    code: (short)GECodeEnum.BotWrongSending.GetDisplayOder(),
                    title: GECodeEnum.BotWrongSending.GetDisplayName(),
                    message: GECodeEnum.BotWrongSending.GetDisplayDescription(),
                    innerException: e)
            };
        }
    }
}