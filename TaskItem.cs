using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecurityChatbotGUI
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReminderDate { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title, string description, DateTime? reminderDate = null)
        {
            Title = title;
            Description = description;
            ReminderDate = reminderDate;
            IsCompleted = false;
        }

        public override string ToString()
        {
            string reminder = ReminderDate.HasValue ? $" (Reminder: {ReminderDate.Value.ToShortDateString()})" : "";
            string status = IsCompleted ? "[Completed]" : "[Pending]";
            return $"{status} {Title}: {Description}{reminder}";
        }
    }
}
