using System.Collections.Generic;
using System.Linq;

namespace Full_GRASP_And_SOLID
{
    public class ProductCatalog
    {
        private static List<Product> catalog;
        public ProductCatalog()
        {
            catalog = new List<Product>();
        }

        public List<Product> Catalog {get;}

        public void AddProductToCatalog(string description, double unitCost)
        {
            Catalog.Add(new Product(description, unitCost));
        }

        public Product GetProduct(string description)
        {
            var query = from Product product in Catalog where product.Description == description select product;
            return query.FirstOrDefault();
        }

        public Product ProductAt(int index)
        {
            return Catalog[index] as Product;
        }
    }
}