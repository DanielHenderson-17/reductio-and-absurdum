public static class ProductAdder
{
    public static void AddProduct(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();
        
        Console.Write("Enter the product name: ");
        string name = Console.ReadLine();
        
        decimal price;
        while (true)
        {
            Console.Write("Enter the product price: ");
            if (decimal.TryParse(Console.ReadLine(), out price)) break;
            Console.WriteLine("Invalid input. Please enter a valid price.");
        }

        Console.Write("Is the product available? (yes/no): ");
        bool isAvailable = Console.ReadLine().ToLower() == "yes";

        Console.WriteLine("Select Product Type:");
        foreach (var type in productTypes)
        {
            Console.WriteLine($"{type.Id}. {type.Name}");
        }

        int typeId = 0;
        bool isValidType = false;
        while (!isValidType)
        {
            Console.Write("Enter the product type ID: ");
            if (int.TryParse(Console.ReadLine(), out typeId))
            {
                isValidType = productTypes.Exists(t => t.Id == typeId);
            }
            
            if (!isValidType)
            {
                Console.WriteLine("Invalid selection. Please choose a valid product type id.");
            }
        }

        products.Add(new Product(name, price, isAvailable, typeId));
        Console.WriteLine("Product added successfully. Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
