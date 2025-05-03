using AppModels.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Interfaces
{
	public interface IProductoRepository
	{
		Task<IEnumerable<Producto>> GetAllAsync();
		Task<Producto?> GetByIdAsync(int id);
		Task AddAsync(Producto producto);
		Task UpdateAsync(Producto producto, int id);
		Task DeleteAsync(int id);
	}
}
