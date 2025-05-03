using AppModels.Entities;
using Data.Data;
using Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
	public class ProductoRepository : IProductoRepository
	{
		private readonly AppDbContext _context;

		public ProductoRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Producto>> GetAllAsync()
		{
			return await _context.Productos.AsNoTracking().ToListAsync();
		}

		public async Task<Producto?> GetByIdAsync(int id)
		{
			return await _context.Productos.FindAsync(id);
		}

		public async Task AddAsync(Producto producto)
		{
			_context.Productos.Add(producto);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Producto producto, int id)
		{
			var result = await _context.Productos.FindAsync(id);
			if (result != null)
			{
				result.Nombre = producto.Nombre;
				result.Precio = producto.Precio;
				result.Stock = producto.Stock;
				result.IdCategoria = producto.IdCategoria;

				await _context.SaveChangesAsync();
			}
		}

		public async Task DeleteAsync(int id)
		{
			var producto = await GetByIdAsync(id);
			if (producto != null)
			{
				_context.Productos.Remove(producto);
				await _context.SaveChangesAsync();
			}
		}
	}
}
