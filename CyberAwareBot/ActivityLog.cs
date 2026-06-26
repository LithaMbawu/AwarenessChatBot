using System;
using System.Collections.Generic;
using System.Linq;

namespace CybersecurityChatbot
{
    public sealed class ActivityLog
    {
        private readonly List<string> _entries = new();

        public void Add(string message)
        {
            string entry = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} - {message}";
            _entries.Insert(0, entry);

            if (_entries.Count > 100)
            {
                _entries.RemoveAt(_entries.Count - 1);
            }
        }

        public IReadOnlyList<string> GetRecentEntries(int count)
        {
            return GetRecentEntries(count, 0);
        }

        public IReadOnlyList<string> GetRecentEntries(int count, int offset)
        {
            if (count <= 0)
            {
                return Array.Empty<string>();
            }

            int startIndex = Math.Max(0, offset);
            if (startIndex >= _entries.Count)
            {
                return Array.Empty<string>();
            }

            return _entries.Skip(startIndex).Take(count).ToList();
        }
    }
}
