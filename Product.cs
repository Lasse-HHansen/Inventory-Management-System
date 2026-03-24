using System;

public class Product
{
    // Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }

    // Constructor
    public Product(int id, string name, decimal price, int stockquantity)
    {
        Id = id;
        Name = name;
        Price = price;
        StockQuantity = stockquantity;
    
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"ID: {Id} | Navn: {Name} | Price: {Price} | Stock Quantity: {StockQuantity}");
    }
}