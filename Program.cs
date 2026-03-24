using System;

class Program
{
    static void Main(string[] args)
    {
        Inventory myWareHouse = new Inventory();
        Product computer = new Product(1, "Gaming Computer", 8999.00m, 22);
        Product phone = new Product(2, "iPhone 17 Pro", 9999.99m, 14);
        Product keyboard = new Product(3, "KeyChrone", 1300.00m, 23);
        Product mouse = new Product(4, "Logitech MX", 799.00m, 10);

        myWareHouse.AddProduct(computer);
        myWareHouse.AddProduct(phone);
        myWareHouse.AddProduct(keyboard);
        myWareHouse.AddProduct(mouse);

        // Adding to the inventory
        myWareHouse.UpdateStock(4, 5);

        // Showing the entire inventory
        Console.WriteLine("--- Inventory ---");
        myWareHouse.ShowInventory();
    }
    
}
