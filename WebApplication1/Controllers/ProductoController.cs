using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        public readonly DbApiContext _dbcontext;

        public ProductoController(DbApiContext _context)
        {
            _dbcontext = _context;
        }
        [HttpGet]
        [Route("Lista")]
        public IActionResult Lista()
        {
            List<Producto> products = new List<Producto>();
            try
            {
                products = _dbcontext.Productos.Include(c => c.oCategoria).ToList();

                return StatusCode(StatusCodes.Status200OK, new{mensaje = "ok", response = products});
                 
            }catch (Exception ex) {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message , response = products });
            }
        }

    }
}
