using System.Web.Http;

namespace HelloWebApi.Controllers
{
    public class HelloController : ApiController
    {
        [HttpGet]
        public string Greet()
        {
            return "Hello, Web!";
        }

        [HttpGet]
        public string Greet([FromUri] string name)
        {
            return "Hello " + name;
        }

        [HttpGet]
        public string Greet([FromUri]string firstName, [FromUri] string lastName)
        {
            return "Hello, " + firstName + " " + lastName;
        }
    }
}
