﻿using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security.OAuth;
using SimpleTokenAuthentication.DAL;
using System.Security.Claims;
using System.Threading.Tasks;

namespace SimpleTokenAuthentication.Providers
{
    public class AuthorizationServerProvider : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            context.OwinContext.Response.Headers.Add("Access-Control-Allow-Origin", new[] { "*" });
            string userName = null;

            using (AuthenticationRepository authenticationRepository = new AuthenticationRepository())
            {
                IdentityUser user = await authenticationRepository.FindUser(context.UserName, context.Password);
                userName = user.UserName;

                if (user == null)
                {
                    context.SetError("invalid_grant", "Incorrect user name or password");
                    return;
                }
            }

            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim("Role", "User"));
            identity.AddClaim(new Claim("UserName", userName));

            context.Validated(identity);
        }
    }
}