using ConsoleApp1;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheStoryWindows.Commands.Abstracts;

namespace TheStoryWindows.Data
{
    internal partial class DataBase
    {
        public string IPAddr { get; set; }
        public string Name { get; set; }
        public List<DataBasePass> Users { get; set; }

        public List<DataBaseEntry> Entries { get; set; }

        public List<CommandBase> Software { get; set; }

        public DataBasePass GetUser(string name)
        {
            return Users.FirstOrDefault(x => x.Login == name);
        }

        public string Query(string query)
        {
            var result = Entries.Where(x => x.Tags.Contains(query)).ToList();

            if(result == null || result.Count == 0)
            {
                return string.Format("No results for query: {0}", query);
            }
            return FormatResults(result);
        }

        private string FormatResults(List<DataBaseEntry> result)
        {
            var sb = new StringBuilder();
            sb.AppendFormat("Found {0} entries", result.Count());
            sb.AppendLine();
            foreach (var item in result)
            {
                sb.AppendFormat("Title: {0}", item.Title);
                sb.AppendLine();
                sb.AppendFormat("Date: {0}", item.Date);
                sb.AppendLine();
                sb.AppendFormat("Content: {0}", item.Content);
                sb.AppendLine();
                sb.Append("Other tags: ");
                foreach (var tag in item.Tags)
                {
                    sb.Append(tag);
                    sb.Append(", ");
                }
                sb.AppendLine();

                if (!item.IsRead)
                {
                    item.IsRead = true;
                    Program.GameController.SpookyMeter += item.ReadSpookyAdd;
                    item.OnRead?.Invoke();
                }
            }
            return sb.ToString();
        }
    }
}

