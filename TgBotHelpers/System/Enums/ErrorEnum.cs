using System.ComponentModel.DataAnnotations;

namespace TgBotHelpers.System.Enums;

public enum ErrorEnum
{
    [Display(Name = "Ошибка отправки сообщения", Description = "Не удалось отправит сообщение! Для подробной информации посмотрите журнал логирования")]
    ErrorSending,
    [Display(Name = "Отсутствует ID чата", Description = "Не получилось получить ID чата")]
    NoChatId,
    [Display(Name = "Отсутствует ID сообщения", Description = "Не получилось получить ID сообщения")]
    NoMessageId,
}