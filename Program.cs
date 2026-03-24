using System;

class Program
{
    static void Main(string[] args)
    {
        Product myProduct = new Product(1, "Computer", 5999.95m, 10);
        myProduct.DisplayDetails();
    }
    
}
