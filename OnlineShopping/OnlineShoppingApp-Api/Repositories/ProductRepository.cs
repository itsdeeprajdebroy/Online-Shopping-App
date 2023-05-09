using OnlineShoppingApp.Contracts;
using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;

namespace OnlineShoppingApp.Repositories
{
    public class ProductRepository : ProductContracts
    {
        private readonly DB_FavouriteUserContext favouriteUserContext;

        public ProductRepository()
        {
            favouriteUserContext = new DB_FavouriteUserContext();
        }

        public Product GetProductByName(string productName)
        {
            try
            {
                Product product = favouriteUserContext.Products.SingleOrDefault(i => i.ProductName == productName);
                return product;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Product> GetProducts()
        {
            try
            {
                List<Product> products = favouriteUserContext.Products.ToList();
                return products;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public Product GetProductById(int productId)
        {
            try
            {
                Product product = favouriteUserContext.Products.SingleOrDefault(i => i.ProductId == productId);
                return product;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
