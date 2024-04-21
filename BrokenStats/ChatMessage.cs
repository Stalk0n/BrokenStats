using System.ComponentModel.DataAnnotations;

namespace BrokenStats;

public class ChatMessage
{
    [Key] public int MessageId { get; set; }
    public string? Data { get; set; }

    public string? Message { get; set; }

    public int NicknameId { get; set; }
    public virtual ChatLogNickname ChatLogNickname { get; set; } = null!;
}