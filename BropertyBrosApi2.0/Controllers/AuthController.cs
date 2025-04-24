using BropertyBrosApi.Models;
using BropertyBrosApi2._0.DTOs.Auth;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BropertyBrosApi2._0.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILogger<AuthController> logger;
        private readonly IConfiguration config;
        private readonly UserManager<AppUser> userManager;
        private readonly TokenService tokenService;

        public AuthController(UserManager<AppUser> userManager, ILogger<AuthController> logger, IConfiguration config, TokenService tokenService)
        {
            this.userManager = userManager;
            this.logger = logger;
            this.config = config;
            this.tokenService = tokenService;
        }

        [HttpPost]
        [Route("Register")]
        public async Task<ActionResult> Register(RegisterDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                AppUser user = new()
                {
                    Email = dto.Email,
                    UserName = dto.Email,
                    PhoneNumber = dto.PhoneNumber,
                };

                IdentityResult result = await userManager.CreateAsync(user, dto.Password);

                if (!result.Succeeded)
                {
                    foreach (var e in result.Errors)
                    {
                        ModelState.AddModelError(e.Code, e.Description);
                    }

                    return BadRequest(ModelState);
                }

                await userManager.AddToRoleAsync(user, "Realtor");
                return Accepted();
            }
            catch(Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return Problem(ex.InnerException.ToString());
                }

                return Problem(ex.Message);
            }
        }

        [HttpPost]
        [Route("Login")]
        public async Task<ActionResult> Login(LoginDTO dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            try
            {
                AppUser? user = await userManager.FindByEmailAsync(dto.Email);
                bool passwordValid = await userManager.CheckPasswordAsync(user, dto.Password);

                if (user == null || !passwordValid)
                {
                    return Unauthorized(dto);
                }

                string token = await tokenService.GenerateTokenAsync(user);

                LoginResponseDTO response = new()
                {
                    Token = token,
                    Email = user.Email,
                    UserId = user.Id,
                };

                return Accepted(response);
            }
            catch (Exception ex)
            {
                if (ex.InnerException != null)
                {
                    return Problem(ex.InnerException.ToString());
                }

                return Problem(ex.Message);
            }
        }
    }
}
