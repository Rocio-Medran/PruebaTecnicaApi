using AppModels.DTOs;
using Microsoft.AspNetCore.Mvc;
using Servicios.Interfaces;

namespace PruebaTecnicaApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductosController : ControllerBase
	{
		private readonly IProductoService _service;

		public ProductosController(IProductoService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetProductos()
		{
			var productos = await _service.GetProductosAsync();
			return Ok(productos);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetProducto(int id)
		{
			var producto = await _service.GetProductoByIdAsync(id);
			if (producto == null) return NotFound();

			return Ok(producto);
		}

		[HttpPost]
		public async Task<IActionResult> AddProducto(CreateProductoDTO productoDTO)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);

			var producto = await _service.AddProductoAsync(productoDTO);
			return CreatedAtAction(nameof(GetProducto), new { id = producto.Id }, producto);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateProducto(UpProductoDTO productoDTO, int id)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);

			var producto = await _service.UpdateProductoAsync(productoDTO, id);
			if (!producto) return NotFound();
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteProducto(int id)
		{
			var producto = await _service.DeleteProductoAsync(id);
			if (!producto) return NotFound();
			return NoContent();
		}
	}
}
