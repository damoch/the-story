using System;
using System.Collections.Generic;

namespace TheStoryWindows.Data
{
    internal class DataBaseEntry
    {
        public List<string> Tags { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }

        public Action OnRead { get; set; }

        public int ReadSpookyAdd { get; set; }
        public bool IsRead { get; set; }

    }
}
