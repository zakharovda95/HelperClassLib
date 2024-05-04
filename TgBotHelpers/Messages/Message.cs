using Core.Extensions;
using Core.Results;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using TgBotHelpers.System;
using TgBotHelpers.System.Enums;
using TgBotHelpers.System.Interfaces;
using TBMessage = Telegram.Bot.Types.Message;

namespace TgBotHelpers.Messages;

public class Message : IMessage
{
    private readonly ITelegramBotClient _client;
    private readonly Update _update;
    private readonly CancellationToken _ctoken;

    public Message(ITelegramBotClient client, Update update, CancellationToken ctocken)
    {
        _client = client;
        _update = update;
        _ctoken = ctocken;
    }

    public virtual async Task<GenericResultExtending<TBMessage>?> Send(string text, bool reply = true, bool markdownMode = false)
    {
        try
        {
            var chatId = _update.Message?.Chat.Id ?? _update.CallbackQuery?.From.Id;
            
            if (chatId is null) return (GenericResultExtending<TBMessage>)ErrorManager.GetError(ErrorEnum.NoChatId);
            var result = await _client.SendTextMessageAsync(
                 chatId: chatId,
                 text: text,
                 cancellationToken: _ctoken,
                 replyToMessageId: reply ? null : _update.Message?.MessageId,
                 parseMode: markdownMode ? ParseMode.MarkdownV2 : ParseMode.Html
             );
            
            return new GenericResultExtending<TBMessage>
             {
                 IsSuccess = true,
                 Title = SuccessEnum.SuccessSending.GetDisplayName(),
                 Message = SuccessEnum.SuccessSending.GetDisplayDescription(),
                 Data = result
             };
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            var exObject = (GenericResultExtending<TBMessage>)ErrorManager.GetError(ErrorEnum.ErrorSending);
            exObject.Exception = e;
            return exObject;
        }
    }
}