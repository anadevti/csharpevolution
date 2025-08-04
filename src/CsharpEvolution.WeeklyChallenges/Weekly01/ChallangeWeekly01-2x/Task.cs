using System;
using System.Collections.Generic;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.ChallangeWeekly01_2x;

public class Task
{
    private string Description;
    bool IsCompleted;
    DateTime StartedAt;
    
    public Task(string description, DateTime startedAt, bool isCompleted) // construtor
    {
        Description = description;
        IsCompleted = false;
        StartedAt = DateTime.Now;
    }
    public void Show()
    {
        Console.WriteLine($"Task: {Description}");
        Console.WriteLine($"Started at: {StartedAt}");
        Console.WriteLine($"Completed: {IsCompleted}");
    }
}