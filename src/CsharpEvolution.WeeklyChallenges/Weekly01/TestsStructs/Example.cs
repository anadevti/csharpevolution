using System;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsStructs;

public struct Example // criando um tipo struct chamado Example, que pode receber valores de tipos primitivos e outros tipos como string, int, etc.
{
    public string Music { get; set; }
    public string Artist { get; set; }
    public int Duration { get; set; }
    public string Genre { get; set; }
    public string Album { get; set; }
    
    public Example(string music, string artist, int duration, string genre, string album) // Constructor, método especial que é chamado quando o struct é instanciado, permitindo inicializar os valores das propriedades.
    {
        Music = music;
        Artist = artist;
        Duration = duration;
        Genre = genre;
        Album = album;
    }
}

class UsingExample // Classe para testar o struct Example
{
    static void Test()
    {
        
        Example example1 = new Example("Shape of You", "Ed Sheeran", 240, "Pop", "Divide"); // Forma de Instanciar o struct Example
        Console.WriteLine(example1.Music, example1.Artist, example1.Duration, example1.Genre, example1.Album);
        
        // tipo
        Example example2 = new Example(); // outra forma de instanciar o struct Example
        example2.Music = "Hello";
        example2.Artist = "Adele";
        example2.Duration = 300;
        example2.Genre = "Pop";
        example2.Album = "25";
        
        Console.WriteLine(example2.Music, example2.Artist, example2.Duration, example2.Genre, example2.Album);
        
    }
}