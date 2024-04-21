using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrokenStats.Tables;

public class BattleLogNickname
{
    [Key] public int NicknameId { get; set; }

    public string? Nick { get; set; }

    public virtual ObservableCollectionListSource<BattleLog> BattleLog { get; } = new();
}