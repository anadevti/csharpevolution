namespace Challenges.Core;

public class Account
{
    // Saldo inicial definido na criação, imutável após inicialização.
    public decimal InitialBalance { get; }

    // Saldo atual alterável somente dentro da classe, seguro contra alterações indevidas externas.
    public decimal ActualBalance { get; private set; }

    // Construtor para inicializar a conta com saldo inicial.
    public Account(decimal initialBalance)
    {
        InitialBalance = initialBalance;
        ActualBalance = initialBalance;
    }

    // Método para atualizar saldo após transações.
    public void UpdateBalance(decimal amount)
    {
        ActualBalance += amount;
    }
    
}