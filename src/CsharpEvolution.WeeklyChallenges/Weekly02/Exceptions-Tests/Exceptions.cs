using System;
using System.IO;

namespace CsharpEvolution.WeeklyChallenges.Weekly02.Exceptions_Tests;

public class Exceptions
{
    string [] Fruits = { "apple", "banana", "orange", "strawberry" };
    
    public void Convert_Int()
    {
        Console.Write("Digite o índice da fruta (0 a 3): ");
        string Prohibited = Console.ReadLine();

        // Tenta converter sem lançar exceção
        if (int.TryParse(Prohibited, out int indice))
        {
            try
            {
                // Tenta acessar o array; pode lançar IndexOutOfRangeException
                string fruit = Fruits[indice];
                Console.WriteLine($"Fruta selecionada: {fruit}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Índice inválido! Informe um valor entre 0 e {Fruits.Length - 1}.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
        }
    }
    public Exceptions()
    {
        Fruits = Fruits;
    }
    
}