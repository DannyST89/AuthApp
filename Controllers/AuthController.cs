using AuthApp.DTOs;
using AuthApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        /// <summary>
        /// Calling the User Model
        /// </summary>
        public static User user = new User();

        /// <summary>
        /// Creating asynchronous method that wraps a user retorning a DTO
        /// </summary>
        /// <param name="request"></param>
        /// <returns>DTO Values to the client</returns>
        [HttpPost("register")]
        private async Task<ActionResult<User>> Register(UserDto request) { 
            
        }
    }
}
