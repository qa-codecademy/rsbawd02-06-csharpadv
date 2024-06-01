namespace Exercise101;

public class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product { Id = 1, Name = "Laptop", Price = 999.99m },
            new Product { Id = 2, Name = "Mouse", Price = 25.50m },
            new Product { Id = 3, Name = "Keyboard", Price = 49.99m },
            new Product { Id = 4, Name = "Monitor", Price = 150.00m },
            new Product { Id = 5, Name = "USB Cable", Price = 5.99m },
            new Product { Id = 6, Name = "External Hard Drive", Price = 89.99m },
            new Product { Id = 7, Name = "Webcam", Price = 45.00m },
            new Product { Id = 8, Name = "Desk Lamp", Price = 30.00m },
            new Product { Id = 9, Name = "Headphones", Price = 70.00m },
            new Product { Id = 10, Name = "Microphone", Price = 120.00m }
        };

        // Step 4a: Find all products with a price greater than 20
        List<Product> greaterThen20 = products
            .Where(p => p.Price > 20)
            .ToList();

        Console.WriteLine("Products with price greater than 20:");
        
        foreach (Product product in greaterThen20)
            Console.WriteLine(product.GetProductDetails());

        Product mostExpensiveProduct = products
            .OrderByDescending(p => p.Price)
            .FirstOrDefault();

        Console.WriteLine("\nThe most expensive product:");

        if (mostExpensiveProduct != null)
            Console.WriteLine(mostExpensiveProduct.GetProductDetails());

        List<Product> orderedProducts = products
            .OrderBy(p => p.Name)
            .ToList();

        Console.WriteLine("\nProducts ordered by name:");
        foreach (Product product in orderedProducts)
            Console.WriteLine(product.GetProductDetails());
    }
}