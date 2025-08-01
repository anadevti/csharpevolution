using System;
namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsAccessible;

public class ExamplesAccessPublic
{
    public int y; // sem restrições de acesso, pode ser acessado de qualquer lugar
}

// exemplo de classe com acesso privado, comentado para não gerar erro de compilação
// private class ExamplesAccessPrivate
// {
//     public int y; // só pode ser acessado dentro da própria classe
// }

// exemplo de classe com acesso protegido, derivado da classe base
class ExamplesAccessProtectedBase
{
    protected int MyValue = 24; // só pode ser acessado dentro da própria classe e classes derivadas
}

class DerivedExamplesAccessProtected : ExamplesAccessProtectedBase
{
    public void ShowValue()
    {
        Console.WriteLine($"Valor protegido: {MyValue}");
    }
}

// exemplo de classe com acesso interno, só pode ser acessado dentro do mesmo assembly

internal class ExampleAccessInternal
{
    public int x; // só pode ser acessado dentro do mesmo assembly
}


// exemplo de acesso protected internal, só pode ser acessado dentro do mesmo assembly e por classes derivadas

public class ExampleAccessProtectedInternal
{
    protected internal int a; // O acesso é limitado ao assembly atual ou aos tipos derivados da classe que os contém.
}

// exemplo de acesso privado protegido, só pode ser acessado dentro da própria classe e por classes derivadas
public class ExampleAccessPrivateProtected
{
    private protected int b; // O acesso é limitado à própria classe e a classes derivadas dentro do mesmo assembly.
}

public class ExampleAcessingPrivate : ExampleAccessPrivateProtected
{
    public void TestPrivateProtected()
    {
        // Acesso permitido, pois estamos na mesma classe derivada
        b = 10; // Modificando o valor da variável privada protegida
        Console.WriteLine($"Valor privado protegido: {b}");
    }
}