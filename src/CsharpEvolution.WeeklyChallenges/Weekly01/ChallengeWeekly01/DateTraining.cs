using System;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.ChallengeWeekly01;

public struct DateTraining
{
    public DateTime Date;
    public int Month;
    public int Year;

    public DateTraining(DateTime date, int month, int year) // Constructor
    {
        Date = date;
        Month = month;
        Year = year;
    }
}