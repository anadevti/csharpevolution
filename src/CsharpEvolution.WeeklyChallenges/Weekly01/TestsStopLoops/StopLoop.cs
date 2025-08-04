using System;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsStopLoops;

public class StopLoop
{
    public void TestBreak()
    {
        int[] numbers = { 1, 2, -3, 4, 0, 5 };
        foreach (int n in numbers)
        {
            if (n < 0)
                continue;
            if (n == 0)
                break;
            Console.WriteLine($"Número positivo: {n}");
        }
    }

    public void TestReturn()
    {
        int[] numbers = { 1, 2, -3, 4, 0, 5 };
        foreach (int n in numbers)
        {
            if (n < 0)
                continue;
            if (n == 0)
                return; // Sai do método
            Console.WriteLine($"Número positivo: {n}");
        }
        Console.WriteLine("Loop terminado.");
    }

}