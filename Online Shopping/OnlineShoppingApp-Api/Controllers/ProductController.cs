using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineShoppingApp.Contracts;
using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;
using OnlineShoppingApp.Repositories;

namespace OnlineShoppingApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository productRepository;

        public ProductController()
        {
            productRepository = new ProductRepository();
        }

        [HttpGet, Route("GetAllProducts")]
        public IActionResult GetAll()
        {
            try
            {
                List<Product> products = productRepository.GetProducts();
                return StatusCode(200, products);
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }
        [HttpGet, Route("GetProductByName/{ProductName}")]
        public IActionResult GetProductByName(string ProductName)
        {
            try
            {
                Product product = productRepository.GetProductByName(ProductName);
                if (product != null)
                    return StatusCode(200, product);
                else
                    return StatusCode(404, "not found");
            }
            catch (Exception)
            {
                return StatusCode(401, "error occured");
            }
        }
        [HttpGet, Route("GetProductByProductId/{pId}")]
        public IActionResult GetProductByPid(int pId)
        {
            try
            {
                Product product = productRepository.GetProductById(pId);
                if (product != null)
                    return StatusCode(200, product);
                else
                    return StatusCode(404, "not found");
            }
            catch (Exception)
            {
                return StatusCode(401, "error occured");
            }
        }
    }
}
