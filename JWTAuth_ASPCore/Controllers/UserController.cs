using System;
using System.Threading.Tasks;
using JWTAuth_ASPCore.Models;
using JWTAuth_ASPCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuth_ASPCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("register")]
        public async Task<ActionResult> RegisterAsync(RegisterModel model)
        {

            var result = await _userService.RegisterAsync(model);
            return Ok(result);
        }

    }




}
