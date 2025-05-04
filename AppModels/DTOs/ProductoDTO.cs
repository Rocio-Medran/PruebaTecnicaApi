using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppModels.DTOs
{
	public class ProductoDTO
	{
		public int Id { get; set; }

		[StringLength(100)]
		public string Nombre {  get; set; }

		[Range(0.01, double.MaxValue)]
		public decimal Precio { get; set; }

		[Range(0, int.MaxValue)]
		public int Stock { get; set; }

		public int IdCategoria { get; set; }
		public string NombreCategoria { get; set; }
	}
}
