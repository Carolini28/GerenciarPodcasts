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
			modelBuilder.Entity<Categoria>().ToTable("Categorias");
			modelBuilder.Entity<Categoria>().HasKey(p => p.CodigoCategoria);
			modelBuilder.Entity<Categoria>().HasMany
				(p => p.Episodio).WithOne(p => p.Categoria).HasForeignKey(p => p.CodigoCategoria);

			modelBuilder.Entity<Autor>().ToTable("Autores");
			modelBuilder.Entity<Autor>().HasKey(p => p.CodigoAutor);
			modelBuilder.Entity<Autor>().HasMany
				(p => p.Episodio).WithOne(p => p.Autor).HasForeignKey(p => p.CodigoAutor);

			modelBuilder.Entity<Episodio>().ToTable("Episodios");
		}
	}
}