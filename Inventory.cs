using System.Collections.Generic;

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
            Console.WriteLine("Lageret er tomt.");
        }

        foreach (Product p in _products)
        {
            p.DisplayDetails();
        }
    }

}