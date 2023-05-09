using OnlineShoppingApp.Contracts;
using OnlineShoppingApp.Entities;
using OnlineShoppingApp.Model;
using OnlineShoppingApp.Repositories;

namespace OnlineShoppingApp_Testing
{
    public class TestUserRepository
    {
        private UserRepository userRepository;
        [SetUp]
        public void Setup()
        {
            userRepository = new UserRepository();
        }

        [Test]
        public void TestAddUser()
        {
            //Arrange
            User user = new User()
            {
                UserName = "Deepraj Debroy",
                EmailAdd = "deepraj123@gmail.com",
                PhNo = "9365560080",
                Password = "pass@1234"
            };
            //Act
            bool status = userRepository.AddUser(user);
            User user1 = userRepository.GetUserDetails(1);
            //Assert
            Assert.IsNotNull(user1);
        }

        [Test]
        public void TestUserLogin()
        {
            //Arrange
            Login login = new Login()
            {
                Email = "deepraj123@gmail.com",
                Password = "pass@1234"
            };
            //Act
            User user = userRepository.UserLogin(login);
            //Assert
            Assert.IsNotNull(user);
        }

        [Test]
        public void TestGetUserDetails()
        {
            //Arrange
            int userId = 1;
            //Act
            User user = userRepository.GetUserDetails(userId);
            //Assert
            Assert.IsNotNull(user);
        }

        [Test]
        public void TestUpdateUser()
        {
            //Arrange
            User user = new User()
            {
                UserId = 1,
                UserName = "vikram",
                EmailAdd = "vikram123@gmail.com",
                PhNo = "9365560080",
                Password = "pass@1234"
            };
            //Act
            userRepository.UpdateUser(user);
            //Assert
            User user1 = userRepository.GetUserDetails(user.UserId);
            Assert.AreEqual(user1.EmailAdd, user.EmailAdd);
        }


        [Test]
        public void TestDeleteUser()
        {
            //Arrange
            int userId = 1;
            //Act
            userRepository.DeleteUser(userId);
            User user = userRepository.GetUserDetails(userId);
            //Assert
            Assert.IsNull(user);
        }
    }
}
