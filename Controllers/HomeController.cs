using Microsoft.AspNetCore.Mvc;

namespace MiApiMysql.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(new 
            { 
                message = "Bienvenido a MiApiMysql", 
                version = "1.0.0",
                documentation = "https://localhost:5001/swagger",
                endpoints = new 
                {
                    productos = "GET https://localhost:5001/api/productos",
                    productoById = "GET https://localhost:5001/api/productos/{id}",
                    crearProducto = "POST https://localhost:5001/api/productos",
                    actualizarProducto = "PUT https://localhost:5001/api/productos/{id}",
                    eliminarProducto = "DELETE https://localhost:5001/api/productos/{id}"
                }
            });
        }
    }
}
