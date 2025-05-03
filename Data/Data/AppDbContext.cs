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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Producto>()
				.HasOne(p => p.Categoria)
				.WithMany(c => c.Productos)
				.HasForeignKey(p => p.IdCategoria)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}
