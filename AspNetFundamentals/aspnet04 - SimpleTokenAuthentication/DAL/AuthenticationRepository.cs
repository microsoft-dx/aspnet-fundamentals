using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using SimpleTokenAuthentication.Models;
using System;
using System.Threading.Tasks;

namespace SimpleTokenAuthentication.DAL
{
    public class AuthenticationRepository : IDisposable
    {
        private AuthenticationContext authenticationContext;
        private UserManager<IdentityUser> userManager;

        public AuthenticationRepository()
        {
            authenticationContext = new AuthenticationContext();
            userManager = new UserManager<IdentityUser>(new UserStore<IdentityUser>(authenticationContext));
        }

        public async Task<IdentityResult> RegisterUser(User userModel)
        {
            IdentityUser user = new IdentityUser()
            {
                UserName = userModel.UserName
            };

            return await userManager.CreateAsync(user, userModel.Password);
        }

        public async Task<IdentityUser> FindUser(string userName, string password)
        {
            return await userManager.FindAsync(userName, password);
        }

        public void Dispose()
        {
            authenticationContext.Dispose();
            userManager.Dispose();
        }
    }
}