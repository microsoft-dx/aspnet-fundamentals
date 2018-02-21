using Microsoft.AspNet.Identity;
using SimpleTokenAuthentication.DAL;
using SimpleTokenAuthentication.Models;
using System.Threading.Tasks;
using System.Web.Http;

namespace SimpleTokenAuthentication.Controllers
{
    [AllowAnonymous]
    public class AccountController : ApiController
    {
        private AuthenticationRepository authenticationRepository;

        public AccountController()
        {
            authenticationRepository = new AuthenticationRepository();
        }

        public async Task<IHttpActionResult> Register(User userModel)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            IdentityResult result = await authenticationRepository.RegisterUser(userModel);

            return Ok();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
                authenticationRepository.Dispose();

            base.Dispose(disposing);
        }
    }
}
