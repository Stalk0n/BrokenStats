using System.ComponentModel;

namespace BrokenStats;

public class Message
{
    public int MessageId { get; set; }
    public string? Data { get; set; }

    public string? message { get; set; }

    public int NicknameId { get; set; }
    public virtual Nickname Nickname { get; set; } = null!;
}