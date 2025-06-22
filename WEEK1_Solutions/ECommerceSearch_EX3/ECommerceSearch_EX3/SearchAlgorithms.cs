using System;
using System.Collections.Generic;

public static class SearchAlgorithms
{
    public static Product LinearSearch(Product[] products, string searchName)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(searchName, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] sortedProducts, string searchName)
    {
        int left = 0, right = sortedProducts.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            int comparison = string.Compare(sortedProducts[mid].ProductName, searchName, true);
            if (comparison == 0)
                return sortedProducts[mid];
            else if (comparison < 0)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }
}
