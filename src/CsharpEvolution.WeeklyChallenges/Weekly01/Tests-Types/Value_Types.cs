using System;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.Tests_Types;

public class ValueTypes // Tipos Primitvos.
{
    public void TestsTypes()
    {
        // Tipos primitivos em C# são tipos de dados que representam valores simples e não possuem métodos ou propriedades associados a eles.
        // Eles são usados para armazenar valores básicos, como números inteiros, números de ponto flutuante, caracteres e booleanos.

        int typeInt = 10; // Tipo inteiro
        double typeDouble = 3.14; // Tipo de ponto flutuante
        char typeCaractere = 'A'; // Tipo caractere
        bool typeBoolen = true; // Tipo booleano

        Console.WriteLine($"Inteiro: {typeInt}, Ponto Flutuante: {typeDouble}, Caractere: {typeCaractere}, Booleano: {typeBoolen}");
    }
}