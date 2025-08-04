using System;
using System.Collections.Generic;
using CsharpEvolution.WeeklyChallenges.Weekly01.ChallangeWeekly01_2x;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.ChallangeWeekly01_2x;

public class TaskManager
{
    List<string>ListTasks = new List<string>();
 
    public void AddTasks(string description, DateTime startedAt)
    {
        
    }
    
    public void ShowAllTasks()
    {
        if (ListTasks.Count == 0)
        {
            Console.WriteLine("Sem tarefas cadastradas.");
            return;
        }

        Console.WriteLine("Tasks:");
        foreach (var task in ListTasks)
        {
            Console.WriteLine($"- {task}");
        }
    }
    
    public void TaskIsDone(string description)
    {
        if (ListTasks.Contains(description))
        {
            Console.WriteLine($"Task '{description}' está concluída.");
            ListTasks.Remove(description);
        }
        else
        {
            Console.WriteLine($"Task '{description}' não encontrada.");
        }
    }
    
    public void RemoveTasksDone(string description)
    {
        if (ListTasks.Contains(description))
        {
            ListTasks.Remove(description);
            Console.WriteLine($"Task '{description}' removida com sucesso.");
        }
        else
        {
            Console.WriteLine($"Task '{description}' não encontrada.");
        }
    }
}