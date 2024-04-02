using System.ComponentModel.DataAnnotations;

namespace ExceptionHelpers;

public enum GECodeEnum
{
    [Display(Order = 601, Name = "TgBot: Ошибка отправки сообщения", Description = "Не удалось отправить сообщение")]
    BotWrongSending,
}