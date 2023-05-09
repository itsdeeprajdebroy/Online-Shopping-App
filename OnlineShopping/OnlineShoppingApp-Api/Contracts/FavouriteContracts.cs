using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;

namespace OnlineShoppingApp.Contracts
{
    public interface FavouriteContracts
    {
        public bool AddToFavouriteList(Favourite favourite);
        public List<FavouriteProduct> GetFavouriteProducts(int userId);
        public void DeleteFavouriteItem(int productId, int userId);
        public List<FavouriteProduct> GetFavouriteItemByName(string favouriteItemName, int userId);
        public bool UpdateFavouriteList(Favourite favourite);
        public FavouriteProduct GetFavouriteProductById(int FavId);
    }
}
