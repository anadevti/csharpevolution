using System;
using System.Linq.Expressions;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsStructs;
using CsharpEvolution.WeeklyChallenges.Weekly01.Tests_Types;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsOperadores;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsConstructors;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsDestructors;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsConditionals;
using CsharpEvolution.WeeklyChallenges.Weekly01.ChallengeWeekly01;
using CsharpEvolution.WeeklyChallenges.Weekly01.ChallangeWeekly01_2x;
using CsharpEvolution.WeeklyChallenges.Weekly02.Exceptions_Tests;
using CsharpEvolution.WeeklyChallenges.Weekly03;

namespace CsharpEvolution.WeeklyChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStringReader testStringReader = new TestStringReader();
            testStringReader.Path = @"C:\Users\aninha\Documents\aws-palestra";
            testStringReader.ProcessDirectory();
        }
    }
}