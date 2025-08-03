using System;
namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsConditionals;


// Conditional simple - Usar quando há apenas uma possibilidade de execução.

public class ConditionalSimple
{
    private int Age = 24;

    public void CheckAge()
    {
        if (Age >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
    }

    // Conditional with else (composta) - Usar quando há apenas duas possibilidades.
    public void CheckAge2()
    {
        if (Age >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        }
    }

    // Conditional with else if (encadeada) - Usar quando há mais de duas possibilidades.
    public void CheckAge3()
    {
        if (Age < 13)
        {
            Console.WriteLine("Você é uma criança.");
        }
        else if (Age < 18)
        {
            Console.WriteLine("Você é um adolescente.");
        }
        else if (Age < 60)
        {
            Console.WriteLine("Você é um adulto.");
        }
        else
        {
            Console.WriteLine("Você é um idoso.");
        }
    }
    
    // Conditional with switch - Usar quando há várias possibilidades, especialmente com valores discretos. e costuma ficar mais legível que vários else if.
    public void CheckAge4()
    {
        string ageCategory = Age switch
        {
            < 13 => "Você é uma criança.",
            < 18 => "Você é um adolescente.",
            < 60 => "Você é um adulto.",
            _ => "Você é um idoso."
        };
        Console.WriteLine(ageCategory);
    }
}