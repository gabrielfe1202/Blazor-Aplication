using Blazor.AplicationWeb.Shared;
using Microsoft.AspNetCore.Mvc;

namespace Blazor.AplicationWeb.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<int> Get()
        {
            List<int> teste = new List<int>() { 1, 2, 3 };
            return teste.ToArray();
        }
    }
}
