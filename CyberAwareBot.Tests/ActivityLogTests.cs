using CybersecurityChatbot;
using Xunit;

namespace CyberAwareBot.Tests;

public class ActivityLogTests
{
    [Fact]
    public void GetRecentEntries_WithOffset_ReturnsRequestedSlice()
    {
        var log = new ActivityLog();

        for (int i = 0; i < 15; i++)
        {
            log.Add($"entry {i}");
        }

        IReadOnlyList<string> entries = log.GetRecentEntries(5, 5);

        Assert.Equal(5, entries.Count);
        Assert.Contains("entry 9", entries[0], StringComparison.OrdinalIgnoreCase);
        Assert.Contains("entry 5", entries[^1], StringComparison.OrdinalIgnoreCase);
    }
}
