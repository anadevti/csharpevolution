namespace Challenges.Core;

public class Account
{
    public string PersonName;
    
    // Saldo inicial definido na criação, imutável após inicialização.
    public decimal InitialBalance;

    // Saldo atual alterável somente dentro da classe, seguro contra alterações indevidas externas.
    public decimal ActualBalance { get; private set; }

    // Construtor para inicializar a conta com saldo inicial.
    public Account(decimal initialBalance)
    {
        InitialBalance = initialBalance;
        ActualBalance = initialBalance;
    }

    // Método para atualizar saldo após transações.
    public void Deposit(decimal amount)
    {
        InitialBalance += amount;
    }

    public void ShowDetailsBalance()
    {
        Console.WriteLine($"O Usuario {PersonName} possui um saldo de {InitialBalance:C2}");
    }
    
}