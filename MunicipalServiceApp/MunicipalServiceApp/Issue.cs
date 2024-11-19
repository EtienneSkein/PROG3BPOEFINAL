using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServiceApp
{
    public class Issue
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string MediaFilePath { get; set; }
        public DateTime DateReported { get; set; }
        public int Priority { get; set; }  // Lower number = higher priority
        public string Status { get; set; }  // Status of the issue (e.g., "Open", "In Progress", "Resolved")

        public Issue(int id, string location, string mediaFilePath, string description, string category, DateTime dateReported, int priority, string status)
        {
            Id = id;
            Location = location;
            Category = category;
            MediaFilePath = mediaFilePath;
            Description = description;
            DateReported = dateReported;
            Priority = priority;
            Status = status;
        }

        // Override ToString to display the issue description in UI elements
        public override string ToString()
        {
            return $"Issue {Id}: {Description} ({Status})";
        }
    }
}