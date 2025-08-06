using System;
using System.Collections.Specialized;
using System.Reflection;
using System.Security.Cryptography;
using EnterpriseFinance = Enterprise.finance.Relatory;
using EnterpriseRh = Enterprise.rh.Relatory;

namespace enterprise.employees
{
    class Employee
    {
        public void TestEmployee()
        {
            Console.WriteLine("Olá, sou um funcionário!");
        }
    }
}

namespace Enterprise.finance
{
    class Relatory
    {
        public void TestMethodFinance()
        {
            Console.WriteLine("Olá, sou do Financeiro");
        }
    }
}

namespace Enterprise.rh
{
    class Relatory
    {
        public void TestMethodRh()
        {
            Console.WriteLine("Olá, sou do Rh!");
        }
    }
}

class Car
{
    public string Mark;
    public string Model;
    public int Year;

    public Car(string mark, string model, int year)
    {
        Mark = mark;
        Model = model;
        Year = year;
    }
    
    public void TestCar()
    {
        Console.WriteLine($"Carro da marca: {Mark} Modelo da marca: {Model} ano: {Year}");
    }
}


struct Product
{
    public string Name;
    public decimal Price;
    public string Category;

    public Product(string name, decimal price, String category)
    {
        Name = name;
        Price = price;
        Category = category;
    } 

    List<Product> listProducts = new List<Product>()
    {
        new Product("BMW", 100m, "BMW"),
        new Product("Audi", 200m, "Audi"),
        new Product("Honda", 300m, "Honda")
    };
    public void AddProduct(Product product)
    {
        listProducts.Add(product);
    }

    public void RemoveProduct(Product product)
    {
        listProducts.Remove(product);
    }

    public void CalculatePrice()
    {
        foreach (var media in listProducts)
        {
            var mediaPrice = media.Price;
            mediaPrice = mediaPrice + listProducts.Count;
        }
        
        
    }


    class Program
    {
        static void Main(string[] args)
        {
            EnterpriseFinance enterpriseFinance = new EnterpriseFinance();
            EnterpriseRh enterpriseRh = new EnterpriseRh();
            Console.WriteLine($"Teste instanciacao");
            enterpriseFinance.TestMethodFinance();
            enterpriseRh.TestMethodRh();
            Car car = new Car("Volks", "Gol", 2005);
            car.TestCar();
        }
    }
}