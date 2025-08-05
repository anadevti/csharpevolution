using System;

using EnterpriseFinance = Enterprise.finance.Relatory;
using EnterpriseRh = Enterprise.rh.Relatory;

namespace enterprise.employees
{
    class Employee
    {
        public void TestEmployee()
        {
            Console.WriteLine("Olá, sou um funcionário!");
        }
    }
}

namespace Enterprise.finance
{
    class Relatory
    {
        public void TestMethodFinance()
        {
            Console.WriteLine("Olá, sou do Financeiro");
        }
    }
}

namespace Enterprise.rh
{
    class Relatory
    {
        public void TestMethodRh()
        {
            Console.WriteLine("Olá, sou do Rh!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        EnterpriseFinance enterpriseFinance = new EnterpriseFinance();
        EnterpriseRh enterpriseRh = new EnterpriseRh();
        Console.WriteLine($"Teste instanciacao");
        enterpriseFinance.TestMethodFinance();
        enterpriseRh.TestMethodRh();
    }
}