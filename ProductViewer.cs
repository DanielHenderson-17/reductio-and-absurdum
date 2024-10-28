public static class ProductViewer
{
    public static void ViewAllProducts(List<Product> products)
    {
        Console.Clear();
        Console.WriteLine("All Products:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
        Console.WriteLine("Press any key to return to the main menu...");
        Console.ReadKey();
    }
}
