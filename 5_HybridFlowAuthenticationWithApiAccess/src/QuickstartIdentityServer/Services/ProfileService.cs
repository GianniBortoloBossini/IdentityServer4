using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using IdentityServer4.Models;
using IdentityServer4.Services;

namespace QuickstartIdentityServer.Services
{
    public class ProfileService : IProfileService
    {
        // protected UserManager<ApplicationUser> _userManager;

        public ProfileService() //UserManager<ApplicationUser> userManager)
        {
            // _userManager = userManager;
        }

        public Task GetProfileDataAsync(ProfileDataRequestContext context)
        {
            //>Processing
            // var user = _userManager.GetUserAsync(context.Subject).Result;

            var claims = new List<Claim>
            {
                new Claim("FullName", "Gianni Bortolo Bossini"),
            };

            context.IssuedClaims.AddRange(claims);

            //>Return
            return Task.FromResult(0);
        }

        public Task IsActiveAsync(IsActiveContext context)
        {
            //>Processing
            // var user = _userManager.GetUserAsync(context.Subject).Result;

            context.IsActive = true; // (user != null) && user.IsActive;

            //>Return
            return Task.FromResult(0);
        }
    }
}