using System.Text;
using System.Text.Json;
using WebhookUtility.Extensions;
using WebhookUtility.Objects;

using HttpClient Client = new();

DiscordEmbed[] embed = new[]
{
    new DiscordEmbed
    {
        Title = "Title",
        Description = "Description",
        Color = 16711680,
        Image = new EmbedImage
        {
            Url = "https://cdn.discordapp.com/attachments/679791684548296735/1043816245427965962/image.png"
        },
        Author = new EmbedAuthor
        {
            Name = "Author"
        },
        Footer = new EmbedFooter
        {
            Text = "Footer"
        }
    }
};

DiscordRequest json = new("Hello World!", "Webhook Utility", "https://cdn.discordapp.com/attachments/679791684548296735/1043816245427965962/image.png", false, embed);

const string url = "https://discord.com/api/webhooks/1043861413707395094/AzkGAQDnosm3q1JHCzFdLsw4RMF8y1smlSiOec9dMgdOdmXX3N94bv3QTo1KkzR1qNYf";

string serialized = JsonSerializer.Serialize(json, Json.SnakeCase);
using StringContent content = new(serialized, Encoding.UTF8, "application/json");

await Client.PostAsync(url, content);

await Task.Delay(-1);