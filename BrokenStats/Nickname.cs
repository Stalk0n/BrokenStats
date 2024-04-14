using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace BrokenStats;

public class Nickname
{
    public int NicknameId { get; set; }

    public string? Nick { get; set; }

    public virtual ObservableCollectionListSource<Messages> Messages { get; } = new();
}