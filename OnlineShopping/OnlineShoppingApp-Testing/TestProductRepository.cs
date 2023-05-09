using OnlineShoppingApp.Contracts;
using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;
using OnlineShoppingApp.Repositories;

namespace OnlineShoppingApp_Testing
{
    public class Tests
    {
        private ProductRepository productRepository;
        [SetUp]
        public void Setup()
        {
            productRepository = new ProductRepository();
        }

        [Test]
        public void TestGetProductByName()
        {
            //Arrange
            string productName = "keyboard";
            //Act
            Product product = productRepository.GetProductByName(productName);
            //Assert
            Assert.IsNotNull(product);
        }

        [Test]
        public void TestGetProducts()
        {
            //Arrange
            int count = 0;
            //Act
            List<Product> product = productRepository.GetProducts();
            count = product.Count;
            //Assert
            Assert.Greater(count, 0);
        }
        [Test]
        public void TestGetProductById()
        {
            //Arrange
            int productId = 3;
            //Act
            Product product = productRepository.GetProductById(productId);
            //Assert
            Assert.IsNotNull(product);
        }
    }
}