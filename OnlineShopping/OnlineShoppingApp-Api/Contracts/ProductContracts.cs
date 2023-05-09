using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;

namespace OnlineShoppingApp.Contracts
{
    public interface ProductContracts
    {
        public List<Product> GetProducts();
        public Product GetProductByName(string productName);
        public Product GetProductById(int productId);
    }
}
