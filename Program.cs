using System;

class Program
{
    static void Main(string[] args)
    {
        Inventory myWareHouse = new Inventory();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n --- Inventory System ---");
            Console.WriteLine("1. Show all products");
            Console.WriteLine("2. Add a new product");
            Console.WriteLine("3. Opdate inventory");
            Console.WriteLine("4. Close");
            Console.Write("\n Press a number ");

            string? input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    myWareHouse.ShowInventory();
                    break;
                case "2":
                    Console.WriteLine("\n --- Add a new product ---");
                    Console.Write("Enter ID: ");
                    int id = int.Parse(Console.ReadLine() ?? "0"); 

                    Console.Write("Enter Name: ");
                    string name = Console.ReadLine() ?? "Unknown";

                    Console.Write("Enter Price: ");
                    decimal price = decimal.Parse(Console.ReadLine() ?? "0");

                    Console.Write("Enter Quantity");
                    int quantity = int.Parse(Console.ReadLine() ?? "0");

                    myWareHouse.AddProduct(new Product(id, name, price, quantity));
                    Console.WriteLine("Product added successfully");
                    break; 
                case "3":
                    Console.WriteLine("\n --- Update Stock ---");
                    Console.Write("Enter Product ID");
                    int updateId = int.Parse(Console.ReadLine() ?? "0");

                    Console.WriteLine("Enter amount to add (You can also use negative to remove): ");
                    int amount = int.Parse(Console.ReadLine() ?? "0");

                    myWareHouse.UpdateStock(updateId, amount);
                    break;
                case "4":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;


            }
        }
    }
    
}
