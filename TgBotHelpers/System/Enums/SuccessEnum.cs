using System.ComponentModel.DataAnnotations;

namespace TgBotHelpers.System.Enums;

public enum SuccessEnum
{
    [Display(Name = "Успешная отправка сообщения", Description = "Сообщение отправлено!")]
    SuccessSending,
}