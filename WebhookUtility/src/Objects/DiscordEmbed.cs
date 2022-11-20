namespace WebhookUtility.Objects;

public class DiscordEmbed
{
    ///<summary>
    ///title of embed
    ///</summary>
    public string Title { get; set; }

    ///<summary>
    ///type of embed (always "rich" for webhook embeds)
    ///</summary>
    public EmbedType Type { get; set; }
    
    /// <summary>
    /// description of embed
    /// </summary>
    public string Description { get; set; }
    
    ///<summary>
    ///url of embed
    ///</summary>
    public string Url { get; set; }
    
    ///<summary>
    ///timestamp of embed content
    ///</summary>
    public DateTime Timestamp { get; set; }
    
    ///<summary>
    ///timestamp of embed content
    ///</summary>
    public int Color { get; set; }
    
    ///<summary>
    ///color code of the embed
    ///</summary>
    public EmbedFooter Footer { get; set; }
    
    ///<summary>
    ///footer information
    ///</summary>
    public EmbedImage Image { get; set; }
    
    ///<summary>
    ///image information
    ///</summary>
    public EmbedThumbnail Thumbnail { get; set; }

    ///<summary>
    ///provider information
    ///</summary>
    public EmbedProvider Provider { get; set; }
    
    ///<summary>
    ///author information
    ///</summary>
    public EmbedAuthor Author { get; set; }
    
    ///<summary>
    ///fields information
    ///</summary>
    public EmbedField Fields { get; set; }
}

public class EmbedType
{
    /// <summary>
    /// generic embed rendered from embed attributes
    /// </summary>
    public string Rich { get; set; }
    
    /// <summary>
    /// image embed
    /// </summary>
    public string Image { get; set; }
        
    /// <summary>
    /// video embed
    /// </summary>
    public string Video { get; set; }
        
    /// <summary>
    /// animated gif image embed rendered as a video embed
    /// </summary>
    public string Gifv { get; set; }
        
    /// <summary>
    /// article embed
    /// </summary>
    public string Article { get; set; }
        
    /// <summary>
    /// link embed
    /// </summary>
    public string Link { get; set; }
}

public class EmbedFooter
{
    /// <summary>
    /// footer text
    /// </summary>
    public string Text { get; set; }
    
    /// <summary>
    /// url of footer icon (only supports http(s) and attachments)
    /// </summary>
    public string Icon_Url { get; set; }
        
    /// <summary>
    /// a proxied url of footer icon
    /// </summary>
    public string Proxy_Icon_Url { get; set; }
    
};

public class EmbedImage
{    
    /// <summary>
    /// source url of image (only supports http(s) and attachments)
    /// </summary>
    public string Url { get; set; }
        
    /// <summary>
    /// a proxied url of the image
    /// </summary>
    public string Proxy_Url { get; set; }
        
    /// <summary>
    /// height of image
    /// </summary>
    public int Height { get; set; }
        
    /// <summary>
    /// width of image
    /// </summary>
    public int Width { get; set; }
};

public class EmbedThumbnail
{    
    /// <summary>
    /// source url of thumbnail (only supports http(s) and attachments)
    /// </summary>
    public string Url { get; set; }
    
    /// <summary>
    /// a proxied url of the thumbnail
    /// </summary>
    public string Proxy_Url { get; set; }
    
    /// <summary>
    /// height of thumbnail
    /// </summary>
    public int Height { get; set; }
    
    /// <summary>
    /// width of thumbnail
    /// </summary>
    public int Width { get; set; }
};

public class EmbedVideo
{
    /// <summary>
    /// source url of video
    /// </summary>
    public string Video { get; set; }
    
    /// <summary>
    /// source url of video
    /// </summary>
    public string Proxy_Url { get; set; }
    
    /// <summary>
    /// height of video
    /// </summary>
    public int Height { get; set; }
    
    /// <summary>
    /// width of video
    /// </summary>
    public int Width { get; set; }
}

public class EmbedProvider
{
    /// <summary>
    /// name of provider
    /// </summary>
    public string Name { get; internal set; }

    /// <summary>
    /// url of provider
    /// </summary>
    public string Url { get; internal set; }
}

public class EmbedAuthor
{    
    /// <summary>
    /// name of author
    /// </summary>
    public string Name { get; internal set; }
        
    /// <summary>
    /// url of author
    /// </summary>
    public string Url { get; internal set; }
        
    /// <summary>
    /// url of author icon (only supports http(s) and attachments)
    /// </summary>
    public string Iconurl { get; internal set; }
        
    /// <summary>
    /// a proxied url of author icon
    /// </summary>
    public string Proxyiconurl { get; internal set; }
}
    
public class EmbedField
{    
    /// <summary>
    /// name of the field
    /// </summary>
    public string Name { get; internal set; }
        
    /// <summary>
    /// value of the field
    /// </summary>
    public string Value { get; internal set; }
        
    /// <summary>
    /// whether or not this field should display inline
    /// </summary>
    public bool Inline { get; internal set; }
}