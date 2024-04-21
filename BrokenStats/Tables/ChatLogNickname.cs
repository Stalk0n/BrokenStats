using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BrokenStats.Tables;

public class ChatLogNickname
{
    [Key] public int NicknameId { get; set; }

    public string? Nick { get; set; }

    public virtual ObservableCollectionListSource<ChatMessage> Messages { get; } = new();
}