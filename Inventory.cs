using System.Collections.Generic;
using System;
using System.Diagnostics;

public class Inventory
{
    private List<Product> _products; 

    public Inventory()
    {
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public void ShowInventory()
    {
        if (_products.Count == 0)
        {
            Console.WriteLine("The inventory is empty");
            return; // Stop if inventory is empty
        }

        foreach (Product p in _products)
        {
            p.DisplayDetails();
        }
    }

    public Product FindProductById(int id)
    {
        foreach (Product p in _products)
        {
            if (p.Id == id)
            {
                return p; // Stop when we have found our product
            }
        }
        return null; // If we did not find anything
    }

    public void UpdateStock(int id, int amount)
    {
        Product foundProduct = FindProductById(id);
        if (foundProduct != null)
        {
            foundProduct.StockQuantity += amount;
            Console.WriteLine($"Inventory got updated with: {foundProduct.Name}");
        }
        else
        {
            Console.WriteLine($"Failure. Product with ID {id} was not found.");
        }
    }

}