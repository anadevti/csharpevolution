using System;
namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsDestructors;

public class Users
{
    string Name = "Giovanna";
    
    public Users (string name) => Name = name; // metodo construtor
    
    public void ShowName()
    {
        Console.WriteLine($"Nome: {Name}");
    }
    
    public class DestructorExample
    {
        // Destrutor é chamado quando o objeto é destruído
        ~DestructorExample()
        {
            
        }
        public void ShowMessage()
        {
            Users user = new Users("Giovanna");
            Console.WriteLine("Destrutor chamado");
            user.ShowName();
        }
    }
}