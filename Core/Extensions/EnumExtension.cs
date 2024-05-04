using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Core.Extensions;

public static class EnumExtension
{
    public static string GetDisplayName(this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetName() ?? "";
    }
    
    public static int GetDisplayOder(this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetOrder() ?? -1;
    }
    
    public static string GetDisplayDescription(this Enum enumValue)
    {
        return enumValue.GetType()
            .GetMember(enumValue.ToString())
            .First()
            .GetCustomAttribute<DisplayAttribute>()
            ?.GetDescription() ?? "";
    }
}