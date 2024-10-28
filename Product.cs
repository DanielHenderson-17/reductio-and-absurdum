public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public int ProductTypeId { get; set; }
    public DateTime DateStocked { get; set; }

    public Product(string name, decimal price, bool isAvailable, int productTypeId, DateTime dateStocked)
    {
        Name = name;
        Price = price;
        IsAvailable = isAvailable;
        ProductTypeId = productTypeId;
        DateStocked = dateStocked;
    }

    public int DaysOnShelf
    {
        get
        {
            TimeSpan timeOnShelf = DateTime.Now - DateStocked;
            return timeOnShelf.Days;
        }
    }

    public override string ToString()
    {
        return $"Name: {Name}, Price: {Price:C}, Available: {IsAvailable}, TypeId: {ProductTypeId}, Days on Shelf: {DaysOnShelf}";
    }
}
