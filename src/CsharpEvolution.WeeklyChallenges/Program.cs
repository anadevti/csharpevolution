using System;
using CsharpEvolution.WeeklyChallenges.Weekly01.TestsStructs;
using CsharpEvolution.WeeklyChallenges.Weekly01.Tests_Types;

namespace CsharpEvolution.WeeklyChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
           ReferenceType referenceType = new ReferenceType();
           referenceType.TestsTypes();
           
           ValueTypes valueTypes = new ValueTypes();
           valueTypes.TestsTypes();
           
           UsingExample.Test();
        }
    }
}
