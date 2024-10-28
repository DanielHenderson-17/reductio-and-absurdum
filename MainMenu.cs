public class MainMenu
{
    public static void ShowMenu(List<Product> products, List<ProductType> productTypes)
    {
        string choice = "";
        while (choice != "5")
        {
            Console.Clear();
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. View All Products");
            Console.WriteLine("2. Add a Product to the Inventory");
            Console.WriteLine("3. Delete a Product from the Inventory");
            Console.WriteLine("4. Update a Product in the Inventory");
            Console.WriteLine("5. Exit");

            Console.Write("Please choose an option: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ProductViewer.ViewAllProducts(products);
                    break;
                case "2":
                    ProductAdder.AddProduct(products, productTypes);
                    break;
                case "3":
                    ProductDeleter.DeleteProduct(products);
                    break;
                case "4":
                    ProductUpdater.UpdateProduct(products, productTypes);
                    break;
                case "5":
                    Console.WriteLine("Exiting the program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
