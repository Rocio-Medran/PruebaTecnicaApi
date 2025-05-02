using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AppModels.Entities;
using AppModels.DTOs;

namespace Data.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext>options) : base(options)
		{
		}

		public DbSet<Producto> Productos { get; set; }
		public DbSet<Categoria> Categorias {  get; set; }
	}
}
