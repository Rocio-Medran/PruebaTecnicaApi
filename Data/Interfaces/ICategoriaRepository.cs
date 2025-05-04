using AppModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
	public interface ICategoriaRepository
	{
		Task<IEnumerable<Categoria>> GetAllAsync();
		Task<Categoria?> GetByIdAsync(int id);
		Task<Categoria?> GetConProductosAsync(int id);

		Task AddAsync(Categoria categoria);
		Task UpdateAsync(Categoria categoria, int id);
		Task DeleteAsync(int id);
	}
}
