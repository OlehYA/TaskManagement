using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public record Task
    {
        public int Id { get; init; }
        public string Title { get; init; }
        public TaskType Type { get; init; }
        public TaskPriority Priority { get; init; }
        public TaskStatus Status { get; set; }
        public TaskAttributes Attributes { get; init; }
        public IUser Assignee { get; set; }
    }
}
