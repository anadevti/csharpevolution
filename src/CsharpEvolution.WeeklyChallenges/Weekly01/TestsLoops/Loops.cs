using System;
namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsLoops;

public class Loops
{
    // Loop For 
    public void ForLoopExample()
    {        // inicializacao, condição e incremento
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"For Loop Iteration: {i}");
        }
    }
    
    public void WhileLoopExample()
    {
        int i = 0; // inicializacao
        while (i < 10) // condição
        {
            Console.WriteLine($"While Loop Iteration: {i}");
            i++; // incremento
        }
    }
    
    public void DoWhileLoopExample()
    {
        int i = 0; // inicializacao
        do // executa pelo menos uma vez
        {
            Console.WriteLine($"Do While Loop Iteration: {i}");
            i++; // incremento
        } while (i < 10); // condição
    }
    
    public void forEachLoopExample()
    {
        string[] fruits = { "Apple", "Banana", "Cherry" }; // array de frutas
        foreach (string fruit in fruits) // itera sobre cada fruta
        {
            Console.WriteLine($"Fruit: {fruit}");
        }
    }
}