using System;
using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public static class ProductManager
    {
        private static List<Product> productCatalog = new List<Product>();

        public static void AddProductToCatalog(string description, double unitCost)
        {
            productCatalog.Add(new Product(description, unitCost));
        }

        public static Product ProductAt(int index)
        {
            return productCatalog[index] as Product;
        }

        public static Product GetProduct(string description)
        {
            var query = from Product product in productCatalog where product.Description == description select product;
            return query.FirstOrDefault();
        }
    }
}