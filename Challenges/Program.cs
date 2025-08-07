using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Security.Cryptography;
using Challenges.Core;

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Giovanna", 100);
            account.Deposit(amount:200);
            account.WithDrawn(amount:120);
            account.ShowDetailsBalance();
            Console.WriteLine(account.ActualBalance);
        }
        
    }