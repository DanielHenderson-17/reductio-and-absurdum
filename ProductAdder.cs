public static class ProductAdder
{
    public static void AddProduct(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();
        
        string name;
        while (true)
        {
            Console.Write("Enter the product name: ");
            name = Console.ReadLine() ?? string.Empty;
            if (!string.IsNullOrWhiteSpace(name)) break;
            Console.WriteLine("Product name cannot be empty. Please enter a valid name.");
        }
        
        decimal price;
        while (true)
        {
            Console.Write("Enter the product price: ");
            if (decimal.TryParse(Console.ReadLine(), out price)) break;
            Console.WriteLine("Invalid input. Please enter a valid price.");
        }

        Console.Write("Is the product available? (yes/no): ");
        bool isAvailable = (Console.ReadLine() ?? string.Empty).ToLower() == "yes";

        Console.WriteLine("Select Product Type:");
        foreach (var type in productTypes)
        {
            Console.WriteLine($"{type.Id}. {type.Name}");
        }

        int typeId = 0;
        while (true)
        {
            Console.Write("Enter the product type ID: ");
            if (int.TryParse(Console.ReadLine(), out typeId) && productTypes.Any(t => t.Id == typeId))
            {
                break;
            }
            Console.WriteLine("Invalid selection. Please choose a valid product type id.");
        }

        DateTime dateStocked;
        Console.Write("Enter the stocking date (YYYY-MM-DD) or press Enter to use today’s date: ");
        string dateInput = Console.ReadLine() ?? string.Empty;
        if (string.IsNullOrWhiteSpace(dateInput) || !DateTime.TryParse(dateInput, out dateStocked))
        {
            dateStocked = DateTime.Now; // Default to today if input is empty or invalid
        }

        products.Add(new Product(name, price, isAvailable, typeId, dateStocked));
        Console.WriteLine("Product added successfully. Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
