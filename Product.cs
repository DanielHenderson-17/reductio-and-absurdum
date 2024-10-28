public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public int ProductTypeId { get; set; }

    public Product(string name, decimal price, bool isAvailable, int productTypeId)
    {
        Name = name;
        Price = price;
        IsAvailable = isAvailable;
        ProductTypeId = productTypeId;
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price:C}, Available: {IsAvailable}, TypeId: {ProductTypeId}";
    }
}
