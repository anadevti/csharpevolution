namespace Challenges.Core;

public class Account
{
    private string _personName; 
    
    // Saldo inicial
    private decimal _initialBalance;

    // Saldo atual alterável somente dentro da classe, seguro contra alterações indevidas externas.
    public decimal ActualBalance { get { return _initialBalance;} set { _initialBalance = value; } }

    // Construtor para inicializar a conta com saldo inicial.
    public Account(string personName, decimal initialBalance)
    {
        initialBalance = initialBalance;
        ActualBalance = initialBalance;
        _personName = personName;
        _initialBalance = initialBalance;
    }

    // Método para add saldo após transações.
    public void Deposit(decimal amount)
    {
        _initialBalance += amount;
    }
    
    // Método para remover saldo após transações.
    public void WithDrawn(decimal amount)
    {
        if (amount > ActualBalance)
        {
            Console.WriteLine("Saldo insuficiente");
            return;
        }
    _initialBalance -= amount;
    
    }
    
    
    public void ShowDetailsBalance()
    {
        Console.WriteLine($"O Usuario {_personName} possui um saldo de {_initialBalance:C2}");
    }
    
}