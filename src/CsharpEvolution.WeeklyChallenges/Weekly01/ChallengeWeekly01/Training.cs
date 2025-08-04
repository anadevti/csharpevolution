using System;
using System.Collections.Generic;
using System.Linq;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.ChallengeWeekly01;

public class Training
{
    public DateTime Date;
    public string TypeOfTraining;
    public int Duration;
    
    List<Exercise> _trainings = new List<Exercise>(); // Lista para armazenar os treinos
    
    public void AddTraining() // Método para adicionar um treino à lista
    {
        _trainings.Add(new Exercise("Supino Reto", 4, 12));
        _trainings.Add(new Exercise("Agachamento", 4, 10));
        _trainings.Add(new Exercise("Levantamento Terra", 4, 8));
    }
    
    public void ListTrainings() // Método para listar os treinos
    {
        foreach (var exercise in _trainings) // foreach para percorrer a lista de treinos
        {
            Console.WriteLine($"Exercício: {exercise.Name}, Séries: {exercise.Series}, Repetições: {exercise.Repetitions}");
        }
    }
    
    public void SearchTraining(DateTime date)
    {
        if (_trainings.Count == 0)
        {
            Console.WriteLine("Nenhum treino encontrado.");
            return;
        }
        
        var foundTrainings = _trainings.Where(exercise => this.Date.Date == date.Date).ToList();
    
        if (foundTrainings.Count == 0)
        {
            Console.WriteLine($"Nenhum treino encontrado para a data {date:dd/MM/yyyy}.");
            return;
        }

        Console.WriteLine($"Treinos encontrados para {date:dd/MM/yyyy}:");
        foreach (var exercise in foundTrainings)
        {
            Console.WriteLine($"Exercício: {exercise.Name}, Séries: {exercise.Series}, Repetições: {exercise.Repetitions}");
        }
    }
    
    public void RemoveTraining()
    {
        _trainings.RemoveAt(_trainings.Count - 1);
    }
    
    public void RelatoryWeek()
    {
        if (_trainings.Count == 0)
        {
            Console.WriteLine("Nenhum treino registrado para gerar relatório.");
            return;
        }

        var groupedTrainings = _trainings.GroupBy(exercise => exercise.Name)
            .Select(group => new
            {
                ExerciseName = group.Key,
                TotalSeries = group.Sum(exercise => exercise.Series),
                TotalRepetitions = group.Sum(exercise => exercise.Repetitions)
            });

        Console.WriteLine("Relatório Semanal:");
        foreach (var training in groupedTrainings)
        {
            Console.WriteLine($"Exercício: {training.ExerciseName}, Séries Totais: {training.TotalSeries}, Repetições Totais: {training.TotalRepetitions}");
        }
    }
}