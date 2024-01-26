using LoginApi.Entity;
using Microsoft.AspNetCore.Mvc;

namespace LoginApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {

        private readonly RoseShopDbcontext roseShopDbContext;

        public LoginController (RoseShopDbcontext roseShopDbContext)
        {
            this.roseShopDbContext = roseShopDbContext;
        }


        [Route("")]
        [HttpGet]
        public IActionResult GetUserInformation()
        {
            var x = roseShopDbContext.Users.ToList();

            return Ok(x);
        }



        [HttpPost]
        [Route("")]
        public bool Post([FromForm] string username, [FromForm] string password)
        {
            bool credentialsExist = roseShopDbContext.Users.Any(user => user.UserName == username && user.Password==password);
                      
            return credentialsExist;
        }
    }
}
