using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrokenStats;

public class BattleLog
{
    [Key] public int Id { get; set; }
    public string? Data { get; set; }
    public double? Experience { get; set; }
    public double? Psycho_Experience { get; set; }
    public double? Gold { get; set; }
    public string? Dropped_items { get; set; }
    public string? Opponents { get; set; }
    
    public int NicknameId { get; set; }
    public virtual BattleLogNickname BattleLogNickname { get; set; } = null!;
}