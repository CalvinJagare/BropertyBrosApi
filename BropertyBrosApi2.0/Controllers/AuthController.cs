﻿using BropertyBrosApi.Data;
using BropertyBrosApi.Models;
using BropertyBrosApi2._0.Constants;
using BropertyBrosApi2._0.Data;
using BropertyBrosApi2._0.DTOs.User;
using BropertyBrosApi2._0.Repositories.RepInterfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BropertyBrosApi2._0.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly UserManager<ApiUser> userManager;
        private readonly IConfiguration configuration;
        private readonly IRealtorRepository realtorRepository;

        public AuthController(UserManager<ApiUser> userManager, IConfiguration configuration, IRealtorRepository realtorRepository)
        {
            this.userManager = userManager;
            this.configuration = configuration;
            this.realtorRepository = realtorRepository;
        }

        [HttpPost]
        [Route("registerRealtor")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RegisterRealtor(RegisterRealtorDto dto)
        {
            try
            {
                ApiUser user = new ApiUser()
                {
                    UserName = dto.Email,
                    Email = dto.Email,
                    FirstName = dto.FirstName,
                    LastName = dto.LastName
                };

                var result = await userManager.CreateAsync(user, dto.Password);

                if (result.Succeeded == false)
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return BadRequest(ModelState);
                }

                var realtor = new Realtor()
                {
                    FirstName = dto.FirstName,
                    LastName = dto.LastName,
                    Email = dto.Email,
                    PhoneNumber = dto.PhoneNumber,
                    ProfileUrl = dto.ProfileUrl,
                    RealtorFirmId = dto.RealtorFirmId,
                    User = user
                };

                await realtorRepository.Add(realtor);

                await userManager.AddToRoleAsync(user, "User");
                return Accepted();
            }
            catch
            {
                return Problem($"Something Went Wrong in {nameof(RegisterRealtor)}", statusCode: 500);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<AuthResponseDto>> Login(LoginUserDto loginUserDto)
        {
            try
            {
                var user = await userManager.FindByEmailAsync(loginUserDto.Email);

                if (user == null)
                {
                    return NotFound("User not found");
                }

                var resultValid = await userManager.CheckPasswordAsync(user, loginUserDto.Password);

                if (resultValid == false)
                {
                    return Unauthorized($"Invalid password{loginUserDto}");
                }

                string tokenString = await GenerateToken(user);

                var response = new AuthResponseDto()
                {
                    UserId = user.Id,
                    Token = tokenString,
                    Email = user.Email
                };
                return Ok(response);
            }
            catch
            {
                return Problem($"Something Went Wrong in {nameof(Login)}", statusCode: 500);
            }
        }

        private async Task<string> GenerateToken(ApiUser user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var roles = await userManager.GetRolesAsync(user);
            var roleClaims = roles.Select(role => new Claim(ClaimTypes.Role, role)).ToList();

            var userClaim = await userManager.GetClaimsAsync(user);

            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.Sub,user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti,Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim(CustomClaimTypes.Uid, user.Id),
            }
            .Union(roleClaims)
            .Union(userClaim)
            .ToList();

            Realtor? userRealtor = await realtorRepository.GetByUserIdAsync(user.Id);

            if (userRealtor != null)
            {
                Claim realtorClaim = new(CustomClaimTypes.Rid, userRealtor.Id.ToString());
                claims.Add(realtorClaim);
            }

            var token = new JwtSecurityToken(
                issuer: configuration["JwtSettings:Issuer"],
                audience: configuration["JwtSettings:Audience"],
                claims: claims,
                expires: DateTime.UtcNow.AddMinutes(Convert.ToInt32(configuration["JwtSettings:DurationInMinutes"])),
                signingCredentials: credentials
                );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}