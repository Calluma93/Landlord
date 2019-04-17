using Services.Models.Products;
using System.Collections.Generic;

namespace Services.Abstract
{
    public interface IProductsService
    {
        ProductModel GetProduct(string productName);

        IEnumerable<ProductModel> GetAllProducts();
        IEnumerable<CategoryModel> GetCategories();
    }
}
