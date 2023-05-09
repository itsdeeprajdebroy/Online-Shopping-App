using OnlineShoppingApp.Contracts;
using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;

namespace OnlineShoppingApp.Repositories
{
    public class FavouriteRepository : FavouriteContracts
    {
        private readonly DB_FavouriteUserContext favouriteUserContext;
        private readonly Login login;

        public FavouriteRepository()
        {
            favouriteUserContext = new DB_FavouriteUserContext();
            login = new Login();
        }

        public bool AddToFavouriteList(Favourite favourite)
        {
            try
            {
                //checking if the product is already existing in the fav list
                if (!favouriteUserContext.Favourites.Any(f => f.UserId == favourite.UserId && f.ProductId == favourite.ProductId))
                {

                    favouriteUserContext.Favourites.Add(favourite);
                    favouriteUserContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeleteFavouriteItem(int productId, int userId)
        {
            try
            {
                List<Favourite> favourites = favouriteUserContext.Favourites.Where(f => f.UserId == userId).ToList();
                var favourite = favourites.SingleOrDefault(f => f.ProductId == productId);
                favouriteUserContext.Favourites.Remove(favourite);
                favouriteUserContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<FavouriteProduct> GetFavouriteItemByName(string favouriteItemName, int userId)
        {
            try
            {
                List<FavouriteProduct> favourites = (from f in favouriteUserContext.Favourites
                                           join p in favouriteUserContext.Products
                                            on f.ProductId equals p.ProductId
                                           where f.UserId == userId && p.ProductName == favouriteItemName
                                           select new FavouriteProduct()
                                           {
                                               ProductId = f.ProductId,
                                               FavId = f.FavId,
                                               ProductName = p.ProductName,
                                               DescriptionOfProd = p.DescriptionOfProd,
                                               Image = p.Image,
                                               Price = p.price,
                                               Quantity = p.Quantity
                                           }).ToList();
                return favourites;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<FavouriteProduct> GetFavouriteProducts(int userId)
        {
            try
            {
                List<FavouriteProduct> favourites = (from f in favouriteUserContext.Favourites
                                                     join p in favouriteUserContext.Products
                                                      on f.ProductId equals p.ProductId
                                                     where f.UserId == userId
                                                     select new FavouriteProduct()
                                                     {
                                                         ProductId = f.ProductId,
                                                         FavId = f.FavId,
                                                         ProductName = p.ProductName,
                                                         DescriptionOfProd = p.DescriptionOfProd,
                                                         Image = p.Image,
                                                         Price = p.price,
                                                         Quantity = p.Quantity
                                                     }).ToList();
                return favourites;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public FavouriteProduct GetFavouriteProductById(int FavId)
        {
            try
            {
                FavouriteProduct favourite = (from f in favouriteUserContext.Favourites
                                              join p in favouriteUserContext.Products
                                               on f.ProductId equals p.ProductId
                                              where f.FavId == FavId
                                              select new FavouriteProduct()
                                              {
                                                  ProductId = f.ProductId,
                                                  FavId = f.FavId,
                                                  ProductName = p.ProductName,
                                                  DescriptionOfProd = p.DescriptionOfProd,
                                                  Image = p.Image,
                                                  Price = p.price,
                                                  Quantity = p.Quantity
                                              }).SingleOrDefault();
                return favourite;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateFavouriteList(Favourite favourite)
        {
            try
            {
                //checking if product is already available in the fav list -> only unique products are possible for a user to add to fav list
                if (!favouriteUserContext.Favourites.Any(f => f.UserId == favourite.UserId && f.ProductId == favourite.ProductId))
                {
                    favouriteUserContext.Favourites.Update(favourite);
                    favouriteUserContext.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
