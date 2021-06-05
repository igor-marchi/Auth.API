using System.Threading.Tasks;

namespace Auth.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {

        [HttpGet]
        public async Task<IActionResult> Authenticate() => Ok();

    }
}