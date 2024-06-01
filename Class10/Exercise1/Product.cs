namespace Exercise101;

public class Product : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    public string GetProductDetails()
    {
        return $"Id: {Id}, Name: {Name}, Price: {Price:C}";
    }
}
