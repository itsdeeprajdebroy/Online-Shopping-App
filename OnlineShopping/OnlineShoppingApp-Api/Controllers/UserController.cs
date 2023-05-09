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
    public class UserController : ControllerBase
    {
        private readonly UserRepository userRepository;

        public UserController()
        {
            userRepository = new UserRepository();
        }

        [HttpPost, Route("login")]
        public IActionResult Login(Login login)
        {
            try
            {
                User user = userRepository.UserLogin(login);
                return StatusCode(200, user.UserId);

            }
            catch (Exception)
            {

                return StatusCode(401, "enter valid details");
            }
        }

        [HttpPost, Route("RegisterUser")]
        public IActionResult Registration(User user)
        {
            try
            {
                bool status = userRepository.AddUser(user);
                if (status)
                    return StatusCode(200, user);
                else
                    return StatusCode(400, "user already exists");
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }

        [HttpGet, Route("GetUser/{userId}")]
        public IActionResult GetUser(int userId)
        {
            try
            {
                User user = userRepository.GetUserDetails(userId);
                if (user != null)
                    return StatusCode(200, user);
                else
                    return StatusCode(404, "not found");
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }
        [HttpPut, Route("UpdateUser")]
        public IActionResult EditUser(User user)
        {
            try
            {
                userRepository.UpdateUser(user);
                return StatusCode(200, user);
            }
            catch (Exception)
            {

                return StatusCode(401, "error occured");
            }
        }
        [HttpDelete, Route("DeleteUser/{id}")]
        public IActionResult DeleteUser(int id)
        {
            try
            {
                userRepository.DeleteUser(id);
                return StatusCode(200, "successfull");
            }
            catch (Exception)
            {

                return StatusCode(200, "error occured");
            }
        }
    }
}
