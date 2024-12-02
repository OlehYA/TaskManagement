using System;
using System.Collections.Generic;
using System.Linq;
using TaskManagement;
using TaskStatus = TaskManagement.TaskStatus;

class Program
{
    static void Main(string[] args)
    {
        var userManager = UserManagerSingleton.GetInstance();
        var taskManager = TaskManagerSingleton.GetInstance();

        // Додавання користувачів
        userManager.AddUser("Марія", UserRole.QAEngineer);
        userManager.AddUser("Андрій", UserRole.Developer);

        // Створення завдань
        var task1 = new TaskManagement.Task
        {
            Id = 1,
            Title = "Тестування нового API",
            Type = TaskType.Testing,
            Priority = TaskPriority.High,
            Status = TaskStatus.New,
            Attributes = TaskAttributes.Urgent | TaskAttributes.RequiresReview
        };

        var task2 = new TaskManagement.Task
        {
            Id = 2,
            Title = "Розробка нового модуля",
            Type = TaskType.Development,
            Priority = TaskPriority.Medium,
            Status = TaskStatus.New,
            Attributes = TaskAttributes.ClientVisible
        };

        taskManager.AddTask(task1);
        taskManager.AddTask(task2);

        // Призначення завдання користувачу
        var maria = userManager.GetUserByName("Марія");
        maria?.AssignTask(task1);

        // Зміна статусу
        task1.Status = TaskStatus.Completed;

        // Виведення активних завдань
        Console.WriteLine("Активні завдання:");
        foreach (var task in taskManager.GetActiveTasks())
        {
            Console.WriteLine($"- {task.Title} ({task.Status.ToReadableString()})");
        }

        // Виведення атрибутів
        Console.WriteLine($"Атрибути завдання \"{task1.Title}\": {task1.Attributes.ToDescription()}");
    }
}
