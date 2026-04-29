using Microsoft.AspNetCore.Mvc;
using MIAPIMYSQL.DTOs;
using MIAPIMYSQL.Services;

namespace MIAPIMYSQL.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoService _service;

        public ProductosController(IProductoService service)
        {
            _service = service;
        }

        // GET api/productos
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var productos = await _service.GetAllAsync();
            return Ok(productos);
        }

        // GET api/productos/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var producto = await _service.GetByIdAsync(id);
            if (producto is null)
                return NotFound(new { message = $"Producto con id {id} no encontrado" });

            return Ok(producto);
        }

        // POST api/productos
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ProductoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var producto = await _service.CreateAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = producto.Id }, producto);
        }

        // PUT api/productos/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] ProductoDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var producto = await _service.UpdateAsync(id, dto);
            if (producto is null)
                return NotFound(new { message = $"Producto con id {id} no encontrado" });

            return Ok(producto);
        }

        // DELETE api/productos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _service.DeleteAsync(id);
            if (!result)
                return NotFound(new { message = $"Producto con id {id} no encontrado" });

            return NoContent();
        }
    }
}
