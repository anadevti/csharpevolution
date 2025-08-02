using System;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsStructs;
using CsharpEvolution.WeeklyChallenges.Weekly01.Tests_Types;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsOperadores;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsConstructors;

namespace CsharpEvolution.WeeklyChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
           ReferenceType referenceType = new ReferenceType(); // Instanciando a classe ReferenceType para testar os tipos de referência
           referenceType.TestsTypes();
           
           ValueTypes valueTypes = new ValueTypes(); // Instanciando a classe ValueTypes para testar os tipos primitivos
           valueTypes.TestsTypes();
           
           UsingExample.Test();
           
           Operators salaryCalculator = new Operators(5000.00m, 15, 8); // Instanciando a classe Operators para calcular o salário líquido
           salaryCalculator.CalculateNetSalary();
           
           // Tests contrutores
           
              Product product = new Product("Laptop", 1500.00, 10); // Instanciando a classe Product para testar os construtores
              
              var movie = new Movie("Batman", "Animação"); // Instanciando a classe Movie para testar os construtores
              Console.WriteLine(movie.Title);
        }
    }
}