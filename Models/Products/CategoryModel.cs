using System.Collections.Generic;

namespace Services.Models.Products
{
    public class CategoryModel
    {
        public CategoryModel(string name, IEnumerable<ProductModel> products)
        {
            Name = name;
            Products = products;
        }

        public string Name { get; private set; }

        public IEnumerable<ProductModel> Products { get; private set; }
    }
}
