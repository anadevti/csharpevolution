namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsConstructors;

public class Movie
{

    public Movie(string title, string categotry)
    {
        Title = title;
        Categotry = categotry;
    }
    
    public string Title { get; set; }
    public string Categotry { get; set; }
}

// utilizando primary constructor, (disponível a partir do C# 10)
// public class MovieSecond(string title, string category)
// {
//     public string Title { get; set; } = title;
//     public string Category { get; set; } = category;
// }