using System.Text;
using System.Text.Json;

namespace WebhookUtility.Extensions;

public class SnakeCase : JsonNamingPolicy
{
    public override string ConvertName(string name)
    {
        StringBuilder stringBuilder = new();

        foreach (char c in name)
            stringBuilder.Append(Char.ToLower(c));

        return stringBuilder.ToString();
    }
}

public static class Json
{
    public static readonly JsonSerializerOptions SnakeCase = new()
    {
        PropertyNamingPolicy = new SnakeCase()
    };
}