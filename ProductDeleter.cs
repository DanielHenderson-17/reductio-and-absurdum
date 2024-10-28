public static class ProductDeleter
{
    public static void DeleteProduct(List<Product> products)
    {
        Console.Clear();
        Console.WriteLine("Enter the name of the product to delete:");
        string name = Console.ReadLine();

        var product = products.Find(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (product != null)
        {
            products.Remove(product);
            Console.WriteLine("Product deleted successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }

        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
