
using AssessmentUserInterface.Models;
using AssessmentUserInterface.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace AssessmentUserInterface.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _userRepository.AddUser(user);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            _userRepository.DeleteUser(id);
            return Ok();
        }
    }
}
    
