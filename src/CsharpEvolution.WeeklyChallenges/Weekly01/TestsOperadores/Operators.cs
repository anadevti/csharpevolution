// exercicios de fixação de operadores em C#

// Cálculo de Salário Líquido
// Crie um programa que receba como entrada:
//
// Salário bruto (decimal)
//
// Percentual de desconto de imposto de renda (inteiro, de 0 a 100)
//
// Percentual de contribuição ao INSS (inteiro, de 0 a 100)
//
// Utilize operadores aritméticos e de atribuição compostos para calcular:
//
// Valor descontado de imposto de renda
//
// Valor descontado de INSS
//
// Salário líquido final
//
//     Requisitos
//
// Use precedência de operadores corretamente (multiplicação antes de soma/subtração).
//
//     Utilize operadores de atribuição compostos (+=, -=) ao menos uma vez.
//
//     Exiba cada valor (descontos e Salário líquido) com duas casas decimais.
using System;
namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsOperadores;

public class Operators
{
    // Usando o private pq Significa que esse campo só pode ser acessado de dentro da *mesma classe em que foi declarado*.
    // Nenhuma outra classe ou código externo consegue vê‑lo ou modificá‑lo diretamente.
    private decimal _salary;
    private int _incomeTaxPercentage;
    private int _inssPercentage;
    
    public Operators(decimal salary, int incomeTaxPercentage, int inssPercentage)
    {
        _salary = salary;
        _incomeTaxPercentage = incomeTaxPercentage;
        _inssPercentage = inssPercentage;
    }

    public void CalculateNetSalary()
    {
        // Cálculo do valor descontado de imposto de renda
        decimal incomeTaxDiscount = _salary * _incomeTaxPercentage / 100;
        
        // Cálculo do valor descontado de INSS
        decimal inssDiscount = _salary * _inssPercentage / 100;
        
        // Cálculo do salário líquido final
        decimal netSalary = _salary - incomeTaxDiscount - inssDiscount;
        
        // Exibição dos resultados com duas casas decimais
        Console.WriteLine($"Valor descontado de Imposto de Renda: {incomeTaxDiscount:F2}");
        Console.WriteLine($"Valor descontado de INSS: {inssDiscount:F2}");
        Console.WriteLine($"Salário Líquido Final: {netSalary:F2}");
    }
}