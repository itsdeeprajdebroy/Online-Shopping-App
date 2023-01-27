using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;

namespace OnlineShoppingApp.Contracts
{
    public interface UserContracts
    {
        public User UserLogin(Login login);
        public bool AddUser(User user);
        public void UpdateUser(User user);
        public User GetUserDetails(int userId);
        public void DeleteUser(int userId);
    }
}
