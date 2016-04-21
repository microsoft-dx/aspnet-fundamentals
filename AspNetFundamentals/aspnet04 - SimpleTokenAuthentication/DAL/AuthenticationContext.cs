using Microsoft.AspNet.Identity.EntityFramework;

namespace SimpleTokenAuthentication.DAL
{
    public class AuthenticationContext : IdentityDbContext<IdentityUser>
    {
        public AuthenticationContext()
            : base("AuthenticationContext")
        {
        }
    }
}