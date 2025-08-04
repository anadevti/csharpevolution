using System;
namespace CsharpEvolution.WeeklyChallenges.Weekly01.ChallengeWeekly01;

public class ConsoleView
{
    // Crie um campo privado para armazenar a instância de Training.
    private readonly Training _training;

    // Inicialize o campo no construtor da classe.
    public ConsoleView()
    {
        _training = new Training();
    }

    public void Run()
    {
        var option = Console.ReadLine();

        switch (option)
        {
            case "1":
                AddTraining();
                break;

            case "2":
                ListTrainings();
                break;

            case "3":
                SearchTraining();
                break;

            case "4":
                RemoveTraining();
                break;

            case "5":
                RelatoryWeek();
                break;

            case "6":
                // Encerra a aplicação de forma limpa
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção inválida. Tente novamente.");
                break;
        }
    }
    
    // Agora, todos os métodos usarão a mesma instância _training.
    public void AddTraining()
    {
        _training.AddTraining();
        Console.WriteLine("Treino adicionado com sucesso!");
    }
    public void ListTrainings()
    {
        _training.ListTrainings();
    }

    public void SearchTraining()
    {
        Console.Write("Digite a data do treino (formato: dd/MM/yyyy): ");
        var inputDate = Console.ReadLine();

        if (DateTime.TryParse(inputDate, out var date))
        {
            _training.SearchTraining(date);
        }
        else
        {
            Console.WriteLine("Data inválida. Por favor, use o formato dd/MM/yyyy.");
        }
    }
    public void RemoveTraining()
    {
        _training.RemoveTraining();
        Console.WriteLine("Último treino removido com sucesso!");
    }
    public void RelatoryWeek()
    {
        _training.RelatoryWeek();
    }

    public void ShowMenu()
    {
        Console.WriteLine("\nBem vindo ao seu Diario de Treino!");
        Console.WriteLine("Escolha uma das opções abaixo:");
        Console.WriteLine("1. Adicionar treino");
        Console.WriteLine("2. Listar treinos");
        Console.WriteLine("3. Buscar treino por data (formato: dd/MM/yyyy)");
        Console.WriteLine("4. Remover treino");
        Console.WriteLine("5. Relatório semanal");
        Console.WriteLine("6. Sair");
        Console.Write("Digite a opção desejada: ");
    }
}