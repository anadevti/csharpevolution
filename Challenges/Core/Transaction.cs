using System.Runtime.InteropServices.JavaScript;

namespace Challenges.Core;

public struct Transaction
{
    public decimal Amount { get; }
    public DateTime Date { get; }
    public TransactionTypeEnum TransactionType { get; }
    public CategoryEnum Category { get; }
    public string Description { get; }

    public Transaction(decimal amount, DateTime date, string description, TransactionTypeEnum transactiontype, CategoryEnum category)
    {
        Amount = amount;
        Date = date;
        TransactionType = transactiontype;
        Category = category;
        Description = description;
    }
}
