using System;
using System.Globalization;

namespace CsharpEvolution.WeeklyChallenges.Weekly01.TestsConstructors;

public class Product
{
    public string Name; // campos (fields)
    public double Price;
    public int Quantity;

    public Product(string name, double price, int quantity) // constructor with parameters
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }


    public double TotalValueStock()
    {
        return Price * Quantity;
    }

    public void AddingProducts(int quantity)
    {
        Quantity += quantity;
    }

    public void RemoveProducts(int quantity)
    {
        Quantity -= quantity;
    }

    public override string ToString()
    {
        return Name
               + ", $"
               + Price.ToString("F2", CultureInfo.InvariantCulture)
               + ", "
               + Quantity
               + " units, Total: $"
               + TotalValueStock().ToString("F2", CultureInfo.InvariantCulture);
    }
}