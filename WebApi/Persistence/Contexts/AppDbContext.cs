using Microsoft.EntityFrameworkCore;
using WebApi.Domain.Models;

namespace WebApi.Persistence.Contexts {
	public class AppDbContext : DbContext {
		public virtual  DbSet<Episodio> Episodios { get; set; }
		public virtual  DbSet<Categoria> Categorias { get; set; }
		public virtual DbSet<Autor> Autores { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Episodio>().ToTable("Episodios");
			modelBuilder.Entity<Categoria>().ToTable("Categorias");
			modelBuilder.Entity<Autor>().ToTable("Autores");
		}
	}
}