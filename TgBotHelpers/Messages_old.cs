// using ExceptionHelpers;
// using ExtensionHelpers;
// using ResultHelpers;
// using Telegram.Bot;
// using Telegram.Bot.Types;
// using Telegram.Bot.Types.Enums;
// using Telegram.Bot.Types.ReplyMarkups;
//
// namespace TgBotHelpers;
//
// public static class Messages
// {
//     public static async Task<GenericReturnResult<Message?>> SendText(
//         ITelegramBotClient client,
//         Update update,
//         CancellationToken ctoken,
//         string message,
//         ReplyKeyboardMarkup? replyKeyboard = null,
//         InlineKeyboardMarkup? inlineKeyboard = null,
//         bool deleteKeyboard = false,
//         bool reply = false,
//         bool htmlMode = false
//     )
//     {
//         try
//         {
//             var chatId = update.Message?.Chat.Id ?? update.CallbackQuery?.From.Id;
//
//             if (chatId == null)
//             {
//                 return new GenericReturnResult<Message?>
//                 {
//                     IsSuccess = false,
//                     Title = GRMessages.NoChatId.GetDisplayName(),
//                     Message = GRMessages.NoChatId.GetDisplayDescription()
//                 };
//             }
//
//             object? replyMarkup;
//
//             if (inlineKeyboard != null)
//                 replyMarkup = inlineKeyboard;
//             else if (replyKeyboard != null)
//                 replyMarkup = replyKeyboard;
//             else if (deleteKeyboard)
//                 replyMarkup = new ReplyKeyboardRemove();
//             else replyMarkup = null;
//
//             var result = await client.SendTextMessageAsync(
//                 chatId: chatId,
//                 text: message,
//                 cancellationToken: ctoken,
//                 replyMarkup: replyMarkup as IReplyMarkup,
//                 replyToMessageId: reply ? null : update.Message?.MessageId,
//                 parseMode: htmlMode ? ParseMode.Html : ParseMode.Markdown
//             );
//
//             return new GenericReturnResult<Message?>
//             {
//                 IsSuccess = true,
//                 Title = GRMessages.BotSuccessSending.GetDisplayName(),
//                 Message = GRMessages.BotSuccessSending.GetDisplayDescription(),
//                 Data = result
//             };
//         }
//         catch (Exception e)
//         {
//             return new GenericReturnResult<Message?>
//             {
//                 IsSuccess = false,
//                 Exception = new GenericCustomException(
//                     code: (short)GECodeEnum.BotWrongSending.GetDisplayOder(),
//                     title: GECodeEnum.BotWrongSending.GetDisplayName(),
//                     message: GECodeEnum.BotWrongSending.GetDisplayDescription(),
//                     innerException: e)
//             };
//         }
//     }
//
//     public static async Task<GenericReturnResult<Message?>> EditText(
//         ITelegramBotClient client,
//         Update update,
//         CancellationToken ctoken,
//         string message,
//         InlineKeyboardMarkup? inlineKeyboard = null,
//         bool htmlMode = false
//     )
//     {
//         try
//         {
//             var chatId = update.Message?.Chat.Id ?? update.CallbackQuery?.From.Id;
//             var textMessageId = update.CallbackQuery?.Message?.MessageId ?? update.CallbackQuery?.Message?.MessageId;
//
//             if (chatId == null)
//             {
//                 return new GenericReturnResult<Message?>
//                 {
//                     IsSuccess = false,
//                     Title = GRMessages.NoChatId.GetDisplayName(),
//                     Message = GRMessages.NoChatId.GetDisplayDescription()
//                 };
//             }
//
//             if (textMessageId == null)
//             {
//                 return new GenericReturnResult<Message?>
//                 {
//                     IsSuccess = false,
//                     Title = GRMessages.NoMessageId.GetDisplayName(),
//                     Message = GRMessages.NoMessageId.GetDisplayDescription()
//                 };
//             }
//
//             var result = await client.EditMessageTextAsync(
//                 chatId: chatId,
//                 messageId: (int)textMessageId,
//                 text: message,
//                 cancellationToken: ctoken,
//                 replyMarkup: inlineKeyboard,
//                 parseMode: htmlMode ? ParseMode.Html : ParseMode.Markdown
//             );
//
//             return new GenericReturnResult<Message?>
//             {
//                 IsSuccess = true,
//                 Title = GRMessages.BotSuccessSending.GetDisplayName(),
//                 Message = GRMessages.BotSuccessSending.GetDisplayDescription(),
//                 Data = result
//             };
//         }
//         catch (Exception e)
//         {
//             return new GenericReturnResult<Message?>
//             {
//                 IsSuccess = false,
//                 Exception = new GenericCustomException(
//                     code: (short)GECodeEnum.BotWrongSending.GetDisplayOder(),
//                     title: GECodeEnum.BotWrongSending.GetDisplayName(),
//                     message: GECodeEnum.BotWrongSending.GetDisplayDescription(),
//                     innerException: e)
//             };
//         }
//     }
// }