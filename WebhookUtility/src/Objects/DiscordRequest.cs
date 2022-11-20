using System.Runtime.InteropServices;

namespace WebhookUtility.Objects;

public record DiscordRequest
(
    string Content,
    string Username,
    string Avatar_Url,
    bool TTS,
    DiscordEmbed[] Embeds,
    [Optional] string[] Files,
    [Optional] string Payload_Json,
    [Optional] int Flags,
    [Optional] string Thread_Name,
    [Optional] DiscordAM Allowed_Mentions,
    [Optional] DiscordComponents Components,
    [Optional] DiscordAttachment[] Attachments
);

public class DiscordAM
{
    
}

public class DiscordComponents
{
    
}
