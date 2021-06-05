using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Authenticate() => Ok("Sucesso");

    }
}