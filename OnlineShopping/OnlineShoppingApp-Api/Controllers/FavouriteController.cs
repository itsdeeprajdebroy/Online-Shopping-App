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
    public class FavouriteController : ControllerBase
    {
        private readonly FavouriteRepository favouriteRepository;

        public FavouriteController()
        {
            favouriteRepository = new FavouriteRepository();
        }

        [HttpPost, Route("AddFavourite")]
        public IActionResult AddFavourite(Favourite favourite)
        {
            try
            {
                bool status = favouriteRepository.AddToFavouriteList(favourite);
                if (status)
                    return StatusCode(200, "successfull");
                else
                    return StatusCode(403, "already exists in your list");

            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }

        [HttpGet, Route("GetAllFavouriteProducts/{userId}")]
        public IActionResult GetFavourite(int userId)
        {
            try
            {
                List<FavouriteProduct> products = favouriteRepository.GetFavouriteProducts(userId);
                return StatusCode(200, products);
            }
            catch (Exception)
            {

                return StatusCode(404, "not found");
            }
        }

        [HttpDelete, Route("DeleteFavouriteByProductId/{productId}/{userId}")]
        public IActionResult DeleteFavourite(int productId, int userId)
        {
            try
            {
                favouriteRepository.DeleteFavouriteItem(productId, userId);
                return StatusCode(200, "Deleted item from Wishlist");
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }

        [HttpGet, Route("GetFavouriteProductsByNames/{productName}/{userId}")]
        public IActionResult GetFavouriteByName(string productName, int userId)
        {
            try
            {
                List<FavouriteProduct> products = favouriteRepository.GetFavouriteItemByName(productName, userId);
                return StatusCode(200, products);
            }
            catch (Exception)
            {

                return StatusCode(404, "not found");
            }
        }

        [HttpPut, Route("UpdateFavourate")]
        public IActionResult UpdateFavourite(Favourite favourite)
        {
            try
            {
                bool status = favouriteRepository.UpdateFavouriteList(favourite);
                if(status)
                    return StatusCode(200, "successfull");
                else
                    return StatusCode(403, "the product already exists in your list");

            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }
        [HttpGet, Route("GetFavouriteProductsById/{favId}")]
        public IActionResult GetFavouriteById(int favId)
        {
            try
            {
                FavouriteProduct product = favouriteRepository.GetFavouriteProductById(favId);
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
