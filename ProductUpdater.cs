public static class ProductUpdater
{
    public static void UpdateProduct(List<Product> products, List<ProductType> productTypes)
    {
        Console.Clear();
        Console.WriteLine("Enter the name of the product to update:");
        string name = Console.ReadLine() ?? string.Empty;

        var product = products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product != null)
        {
            decimal newPrice;
            while (true)
            {
                Console.Write("Enter new price: ");
                if (decimal.TryParse(Console.ReadLine(), out newPrice)) break;
                Console.WriteLine("Invalid input. Please enter a valid price.");
            }
            product.Price = newPrice;

            Console.Write("Is the product available? (yes/no): ");
            var input = Console.ReadLine();
            product.IsAvailable = input != null && input.ToLower() == "yes";

            Console.WriteLine("Select new Product Type:");
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
                    isValidType = productTypes.Any(t => t.Id == typeId);
                }

                if (!isValidType)
                {
                    Console.WriteLine("Invalid selection. Please choose a valid product type id.");
                }
            }
            product.ProductTypeId = typeId;

            Console.WriteLine("Product updated successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
