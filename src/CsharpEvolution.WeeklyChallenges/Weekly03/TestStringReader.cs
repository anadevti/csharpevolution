using System;
using System.IO;

namespace CsharpEvolution.WeeklyChallenges.Weekly03;

public class TestStringReader
{
    public string Path = @"C:\Users\aninha\Documents\aws-palestra";

    public void ProcessDirectory()
    {
        if (Directory.Exists(Path))
        {
            Console.WriteLine("Directory found: ");
            string[] files = Directory.GetFiles(Path);

            foreach (string file in files)
            {
                Console.WriteLine(System.IO.Path.GetFileName(file));
            }
        }
        else
        {
            Console.WriteLine("Directory does not exist: ");
        }
    }
}