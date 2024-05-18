using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;

namespace BrokenStats
{
    public class SessionSummaryManager
    {
        private readonly LogsContext _dbContext;

        public SessionSummaryManager(LogsContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string SummarizeSession()
        {
            var battleLogs = _dbContext.BattleLogs.ToList();
            var itemSummary = new Dictionary<string, int>();
            double totalExperience = 0;
            double totalPsychoExperience = 0;
            double totalGold = 0;
            TimeSpan totalSessionTime = TimeSpan.Zero;

            foreach (var log in battleLogs)
            {
                totalExperience += log.Experience ?? 0;
                totalPsychoExperience += log.Psycho_Experience ?? 0;
                totalGold += log.Gold ?? 0;

                if (DateTime.TryParse(log.Data, out DateTime logDate))
                {
                    TimeSpan timeSinceLog = DateTime.Now - logDate;
                    totalSessionTime += timeSinceLog;
                }

                if (!string.IsNullOrEmpty(log.Dropped_items))
                {
                    var items = log.Dropped_items.Split(',');
                    foreach (var item in items)
                    {
                        var trimmedItem = item.Trim();
                        int quantity = 1;
                        var match = Regex.Match(trimmedItem, @"^(.*?)(\((\d+)\))?$");
                        if (match.Success)
                        {
                            trimmedItem = match.Groups[1].Value.Trim();
                            if (match.Groups[3].Success)
                            {
                                quantity = int.Parse(match.Groups[3].Value);
                            }
                        }

                        if (itemSummary.ContainsKey(trimmedItem))
                        {
                            itemSummary[trimmedItem] += quantity;
                        }
                        else
                        {
                            itemSummary[trimmedItem] = 1;
                        }
                    }
                }
            }

            var formattedItems = string.Join(", ", itemSummary.Select(kvp => $"{kvp.Value}x{kvp.Key}"));
            return $"Total Time: {totalSessionTime.TotalMinutes} minutes\n" +
                   $"Total Experience: {totalExperience}\n" +
                   $"Total Psycho Experience: {totalPsychoExperience}\n" +
                   $"Total Gold: {totalGold}\n" +
                   $"Total Dropped Items: {formattedItems}";
        }
    }
}
