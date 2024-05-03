using System.ComponentModel.DataAnnotations;

namespace BrokenStats.Tables;

public class ChartSeries
{
    [Key] public int LogId { get; set; }

    public string? Data { get; set; }

    public int Experience { get; set; }

}