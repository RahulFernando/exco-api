using System.Collections.Generic;
using System.Threading.Tasks;
using exco_api.IService;
using exco_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace exco_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task<IActionResult> UserLoging([FromBody] Login user)
        {
            var userObj = await _userService.UserLoging(user);

            if (userObj != null)
            {
                return Ok(userObj);
            }

            return NotFound("Invalid credentials");
        }
    }
}