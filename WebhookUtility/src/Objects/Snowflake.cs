namespace WebhookUtility.Objects;

//Wtf is a Snowflake
//Also pasted from PRAW LOL

public class Snowflake
{
    private static readonly DateTime UnixEpoch = DateTime.UnixEpoch;
    private const long DiscordEpoch = (long)1.4200704E12;

    public DateTime TimeStamp { get; private set; }
    public int InternalWorkerID { get; private set; }
    public int InternalProcessID { get; private set; }
    public int Increment { get; private set; }

    public Snowflake(long snowflake)
    {
        TimeStamp = UnixEpoch.AddMilliseconds((snowflake >> 22) + DiscordEpoch);
        InternalWorkerID = (int)(snowflake & 0x3E0000) >> 17;
        InternalProcessID = (int)(snowflake & 0x1F000) >> 12;
        Increment = (int)snowflake & 0xFFF;
    }

    public long ToSnowflake(DateTime time) =>
        (ToMs(time) - DiscordEpoch) << 22;

    public long ToMs(DateTime time) =>
        (long)time.ToUniversalTime().Subtract(UnixEpoch).TotalMilliseconds;
}