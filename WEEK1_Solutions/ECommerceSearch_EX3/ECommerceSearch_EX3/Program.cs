using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Product[] products = new Product[]
        {
            new Product(101, "Laptop", "Electronics"),
            new Product(102, "Shoes", "Fashion"),
            new Product(103, "Phone", "Electronics"),
            new Product(104, "Table", "Furniture"),
            new Product(105, "Watch", "Accessories")
        };

        Console.WriteLine("Enter product name to search:");
        string searchKey = Console.ReadLine();

        // Linear Search
        var linearResult = SearchAlgorithms.LinearSearch(products, searchKey);
        Console.WriteLine("\nLinear Search Result:");
        Console.WriteLine(linearResult != null ? linearResult.ToString() : "Product not found.");

        // Binary Search
        var sortedProducts = products.OrderBy(p => p.ProductName).ToArray();
        var binaryResult = SearchAlgorithms.BinarySearch(sortedProducts, searchKey);
        Console.WriteLine("\nBinary Search Result:");
        Console.WriteLine(binaryResult != null ? binaryResult.ToString() : "Product not found.");
    }
}
