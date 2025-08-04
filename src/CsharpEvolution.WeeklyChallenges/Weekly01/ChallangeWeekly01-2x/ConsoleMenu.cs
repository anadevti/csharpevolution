using System;
namespace CsharpEvolution.WeeklyChallenges.Weekly01.ChallangeWeekly01_2x;

public class ConsoleMenu
{
    
    private readonly string[] _tasks;
    
    public void ShowMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Adicionar Tarefa");
        Console.WriteLine("2. Adicionar Livro");
        Console.WriteLine("3. Emprestar Livro");
        Console.WriteLine("4. Devolver Livro");
        Console.WriteLine("5. Ver Empréstimos");
        Console.WriteLine("6. Sair");
        Console.Write("Escolha uma opção: ");
    }
}