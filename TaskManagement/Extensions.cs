using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement
{
    public static class Extensions
    {
        public static string ToDescription(this TaskAttributes attributes)
        {
            if(attributes == TaskAttributes.None) return "Без додаткових атрибутів";

            return string.Join(", ", Enum.GetValues(typeof(TaskAttributes))
                .Cast<TaskAttributes>()
                .Where(attr => attributes.HasFlag(attr) && attr != TaskAttributes.None)
                .Select(attr => attr switch
                {
                    TaskAttributes.Urgent => "Термінове",
                    TaskAttributes.RequiresReview => "Потребує перевірки",
                    TaskAttributes.HighRisk => "Високий ризик",
                    TaskAttributes.ClientVisible => "Видиме клієнту",
                    _ => attr.ToString()
                }));
        }

        public static string ToReadableString(this TaskStatus status)
        {
            return status switch
            {
                TaskStatus.New => "Нове завдання",
                TaskStatus.InProgress => "У процесі виконання",
                TaskStatus.Completed => "Завершене",
                TaskStatus.Cancelled => "Скасоване",
                _ => status.ToString()
            };
        }
    }
}
