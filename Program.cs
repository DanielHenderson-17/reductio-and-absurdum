﻿public class Program
{
    public static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product("broom", 15, true, 1, new DateTime(2023, 10, 15)),
            new Product("cauldron", 45, true, 2, new DateTime(2023, 9, 20))
        };

        List<ProductType> productTypes = new List<ProductType>
        {
            new ProductType(1, "Apparel"),
            new ProductType(2, "Potions"),
            new ProductType(3, "Enchanted Objects"),
            new ProductType(4, "Wands")
        };

        MainMenu.ShowMenu(products, productTypes);
    }
}
