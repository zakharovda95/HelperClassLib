using System.ComponentModel.DataAnnotations;

namespace ResultHelpers;

public enum GRMessages
{
    #region TgBot

    [Display(Name = "TgBot: Успешная отправка сообщения", Description = "Сообщение отправлено")]
    BotSuccessSending,
    [Display(Name = "TgBot: Отсутствует ID чата", Description = "Не получилось получить ID чата")]
    NoChatId,
    [Display(Name = "TgBot: Отсутствует ID сообщения", Description = "Не получилось получить ID сообщения")]
    NoMessageId,
    #endregion
}