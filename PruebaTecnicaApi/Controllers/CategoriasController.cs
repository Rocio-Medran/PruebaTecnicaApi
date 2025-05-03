using AppModels.DTOs;
using Microsoft.AspNetCore.Mvc;
using Servicios.Interfaces;
using Servicios.Servicios;

namespace PruebaTecnicaApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriasController : ControllerBase
	{
		private readonly ICategoriaService _service;

		public CategoriasController(ICategoriaService service)
		{
			_service = service;
		}

		[HttpGet]
		public async Task<IActionResult> GetCategorias()
		{
			var categorias = await _service.GetCategoriasAsync();
			return Ok(categorias);
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> GetCategoria(int id)
		{
			var categoria = await _service.GetCategoriaByIdAsync(id);
			if (categoria == null) return NotFound();

			return Ok(categoria);
		}

		[HttpPost]
		public async Task<IActionResult> AddCategoria(CreateCategoriaDTO categoriaDTO)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);

			var categoria = await _service.AddCategoriaAsync(categoriaDTO);
			return CreatedAtAction(nameof(GetCategoria), new { id = categoria.Id }, categoria);
		}

		[HttpPut("{id}")]
		public async Task<IActionResult> UpdateCategoria(CreateCategoriaDTO categoriaDTO, int id)
		{
			if (!ModelState.IsValid) return BadRequest(ModelState);

			var categoria = await _service.UpdateCategoriaAsync(categoriaDTO, id);
			if (!categoria) return NotFound();
			return NoContent();
		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteCategoria(int id)
		{
			var categoria = await _service.DeleteCategoriaAsync(id);
			if (!categoria) return NotFound();
			return NoContent();
		}
	}
}
