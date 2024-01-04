using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GreetingsController : ControllerBase
    {
        [HttpGet(Name = "GetGreeting")]
        public string Get()
        {
            return "¡Hola! Bienvenido a mi aplicación ASP.NET Core.";
        }
    }
}
