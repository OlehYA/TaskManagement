using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    [Flags]
    public enum TaskAttributes  
    {
        None = 0,
        Urgent = 1,
        RequiresReview = 2,
        HighRisk = 4,
        ClientVisible = 8
    }

    public enum TaskStatus
    {
        New,
        InProgress,
        Completed,
        Cancelled
    }

    public enum TaskPriority
    {
        Low,
        Medium,
        High
    }

    public enum TaskType
    {
        Development,
        Testing,
        Documentation
    }

    public enum UserRole
    {
        Developer,
        QAEngineer
    }
}
