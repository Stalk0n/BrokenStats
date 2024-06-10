using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrokenStats.Tables;

public class BattleLog
{
    [Key] public int Id { get; set; }
    public string? Data { get; set; }
    public double? Experience { get; set; }
    public double? PsychoExperience { get; set; }
    public double? Gold { get; set; }
    public string? DroppedItems { get; set; }
    public string? Opponents { get; set; }

    public int NicknameId { get; set; }
    public virtual BattleLogNickname BattleLogNickname { get; set; } = null!;
}