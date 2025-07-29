using System;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.Tests_Types;

public class ReferenceType
{
    // Tipos de referência são tipos de dados que armazenam uma referência a um objeto na memória, em vez de armazenar o valor diretamente.
    // Isso significa que quando você cria uma variável de tipo de referência, ela aponta para um local na memória onde o objeto real está armazenado.
    // Quando você copia uma variável de tipo de referência, você está copiando a referência, não o objeto em si.
    
    public void TestsTypes()
    {
        string text = "Olá, Mundo!"; // Tipo de referência (string)
        object objectTest = new object(); // Tipo de referência (object)

        Console.WriteLine($"Texto: {text}, Objeto: {objectTest}");
    }
}