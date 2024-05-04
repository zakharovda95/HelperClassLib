using Core.Extensions;
using Core.Results;
using Telegram.Bot.Types;
using TgBotHelpers.System.Enums;

namespace TgBotHelpers.System;

public static class ErrorManager
{
    public static GenericResult GetError(ErrorEnum errorType)
    {
        var result = errorType switch
        {
            ErrorEnum.ErrorSending => new GenericResult
            {
                IsSuccess = false,
                Title = ErrorEnum.ErrorSending.GetDisplayName(),
                Message = ErrorEnum.ErrorSending.GetDisplayDescription(),
            },
            ErrorEnum.NoChatId => new GenericResult
            {
                IsSuccess = false,
                Title = ErrorEnum.NoChatId.GetDisplayName(),
                Message = ErrorEnum.NoChatId.GetDisplayDescription(),
            },
            ErrorEnum.NoMessageId => new GenericResult
            {
                IsSuccess = false,
                Title = ErrorEnum.NoMessageId.GetDisplayName(),
                Message = ErrorEnum.NoMessageId.GetDisplayDescription(),
            },
            _ => new GenericResultExtending<Message?>()
        };

        return result;
    }
}