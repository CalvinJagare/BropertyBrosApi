using BropertyBrosApi2._0.Constants;
using BropertyBrosApi2._0.DTOs.Auth;
using BropertyBrosApi2._0.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BropertyBrosApi2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApiUser> userManager;

        public AuthController(UserManager<ApiUser> userManager)
        {
            this.userManager = userManager;
        }
        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(UserDto userDto)
        {
            try
            {
                ApiUser user = new ApiUser()
                {
                    UserName = userDto.Email,
                    Email = userDto.Email,
                    FirstName = userDto.FirstName,
                    LastName = userDto.LastName,
                };
                var result = await userManager.CreateAsync(user, userDto.Password);
                if (result.Succeeded == false)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }
                await userManager.AddToRoleAsync(user, ApiRoles.User);
                return Accepted();
            }
            catch (Exception ex)
            {

                return Problem($"Something went wrong in {nameof(Register)}", statusCode: 500);
            }
            
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login(LoginUserDto userDto)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(userDto.Email);
                var passwordValid = await userManager.CheckPasswordAsync(user, userDto.Password);
                if (user == null || passwordValid == false) 
                {
                    return NotFound();
                }
                //Add what ever is needed to create a JWT
                return Accepted();
            }
            catch (Exception)
            {

                return Problem($"Something went wrong in {nameof(Login)}", statusCode: 500);
            }
        }
    }
}
