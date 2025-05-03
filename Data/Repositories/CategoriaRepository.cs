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
	public class CategoriaRepository : ICategoriaRepository
	{
		private readonly AppDbContext _context;

		public CategoriaRepository(AppDbContext context)
		{
			_context = context;
		}

		public async Task<IEnumerable<Categoria>> GetAllAsync()
		{
			return await _context.Categorias.AsNoTracking().ToListAsync();
		}

		public async Task<Categoria?> GetByIdAsync(int id)
		{
			return await _context.Categorias.FindAsync(id);
		}

		public async Task AddAsync(Categoria categoria)
		{
			_context.Categorias.Add(categoria);
			await _context.SaveChangesAsync();
		}

		public async Task UpdateAsync(Categoria categoria, int id)
		{
			var result = await _context.Categorias.FindAsync(id);
			if (result != null)
			{
				result.Nombre = categoria.Nombre;
				await _context.SaveChangesAsync();
			}
		}

		public async Task DeleteAsync(int id)
		{
			var categoria = await GetByIdAsync(id);
			if (categoria != null)
			{
				_context.Categorias.Remove(categoria);
				await _context.SaveChangesAsync();
			}
		}
	}
}
