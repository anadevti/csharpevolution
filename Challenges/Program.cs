using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Security.Cryptography;
using Challenges.Core;

    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(100);
            account.PersonName = "Aninha";
            account.Deposit(amount:200);
            account.ShowDetailsBalance();
            //Console.WriteLine($"Teste instanciacao");
        }
        
    }