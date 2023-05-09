using OnlineShoppingApp.Contracts;
using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;

namespace OnlineShoppingApp.Repositories
{
    public class UserRepository : UserContracts
    {
        private readonly DB_FavouriteUserContext favouriteUserContext;
        private readonly Login login;

        public UserRepository()
        {
            favouriteUserContext = new DB_FavouriteUserContext();
            login = new Login();
        }

        public User UserLogin(Login login)
        {
            try
            {
                User user = favouriteUserContext.Users.SingleOrDefault(u => u.EmailAdd == login.Email && u.Password == login.Password);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddUser(User user)
        {
            try
            {
                if(!favouriteUserContext.Users.Any(u => u.PhNo == user.PhNo || u.EmailAdd == user.EmailAdd))
                {
                    favouriteUserContext.Users.Add(user);
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

        public void DeleteUser(int userId)
        {
            try
            {
                var user = favouriteUserContext.Users.Find(userId);
                favouriteUserContext.Users.Remove(user);
                favouriteUserContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User GetUserDetails(int userId)
        {
            try
            {
                User user = favouriteUserContext.Users.SingleOrDefault(u => u.UserId == userId);
                return user;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateUser(User user)
        {

            try
            {
                 favouriteUserContext.Users.Update(user);
                 favouriteUserContext.SaveChanges();
              
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
