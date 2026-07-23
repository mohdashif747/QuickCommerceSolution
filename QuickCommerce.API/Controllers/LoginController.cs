using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace QuickCommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public IActionResult Login()
        {
            return Ok();
        }
        public IActionResult LogOut()
        {
            return Ok();
        }
    }
}
