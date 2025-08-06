using System.Runtime.InteropServices.JavaScript;

namespace Challenges.Core;

public struct Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    //public TransactionType Type { get; }
    //public BudgetCategory Category { get; }
    public string Description { get; }

    public Transaction(decimal amount, DateTime date, string description)
    {
        Amount = amount;
        Date = date;
       // Type = type;
       // Category = category;
        Description = description;
    }
}
