
using JWTAuth_ASPCore.Constants;
using JWTAuth_ASPCore.Models;
using JWTAuth_ASPCore.Settings;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;


namespace JWTAuth_ASPCore.Services
{

    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JWT _jwt;


        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IOptions<JWT> jwt)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _jwt = jwt.Value;
        }

        public Task<AuthenticationModel> GetTokenAysnc(TokenRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<string> Register(RegisterModel model)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RegisterAsync(RegisterModel model)
        {
            var user = new ApplicationUser
            {
                UserName = model.Username,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName

            };

            var useWithSameEmail = await _userManager.FindByEmailAsync(model.Email);
            if (useWithSameEmail == null)
            {
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, Authorization.default_role.ToString());
                }
                return $"User Registered with username {user.UserName}";
            }
            else
            {
                return $"Email {user.Email} is already registered.";
            }
        }
    }
}