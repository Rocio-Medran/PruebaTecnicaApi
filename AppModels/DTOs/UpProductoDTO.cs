using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DTOs
{
	public class UpProductoDTO
	{
		public string? Nombre { get; set; }
		public decimal? Precio { get; set; }
		public int? Stock { get; set; }
		public int? IdCategoria { get; set; }
	}
}
