namespace WebhookUtility.Objects;

public class DiscordAttachment
{
    /// <summary>
    /// attachment id
    /// </summary>
    public Snowflake Id { get; set; }
    
    /// <summary>
    /// name of file attached
    /// </summary>
    public string FileName { get; set; }
    
    /// <summary>
    /// description for the file (max 1024 characters)
    /// </summary>
    public string Description { get; set; }
    
    /// <summary>
    /// the attachment's media type (https://en.wikipedia.org/wiki/Media_type)
    /// </summary>
    public string Content_Type { get; set; }
    
    /// <summary>
    /// size of file in bytes
    /// </summary>
    public int Size { get; set; }
    
    /// <summary>
    /// source url of file
    /// </summary>
    public string Url { get; set; }
    
    /// <summary>
    /// 	a proxied url of file
    /// </summary>
    public string Proxy_Url { get; set; }
    
    /// <summary>
    /// height of file (if image)
    /// </summary>
    public int Height { get; set; }
    
    /// <summary>
    /// width of file (if image)
    /// </summary>
    public int Width { get; set; }
    
    /// <summary>
    /// whether this attachment is ephemeral
    /// </summary>
    public bool Ephemeral { get; set; }
}